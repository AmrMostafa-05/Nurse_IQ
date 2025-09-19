using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Data;
using Nurse_IQ.Models;
using Nurse_IQ.Enums.User;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nurse_IQ.Controllers
{
    [Authorize]
    public class ArticlesController : Controller
    {
        private static readonly List<Article> _articles = SeedData.Articles.ToList();
        private static readonly List<applicationUser> _users = SeedData.Users.ToList();

        //articles
        [AllowAnonymous]
        public IActionResult Index(string? category = null, string? search = null)
        {
            var articlesQuery = _articles.AsQueryable();

            // filter
            if (!string.IsNullOrEmpty(category) && category != "all")
            {
                articlesQuery = articlesQuery.Where(a => a.category == category);
            }

            // search
            if (!string.IsNullOrEmpty(search))
            {
                articlesQuery = articlesQuery.Where(a =>
                    a.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    a.Description.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    a.category.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            var articles = articlesQuery.OrderByDescending(a => a.publishDate).ToList();

            
            ViewBag.Categories = _articles
                .Select(a => a.category)
                .Distinct()
                .ToList();

            ViewBag.CurrentCategory = category;
            ViewBag.SearchTerm = search;

            return View(articles);
        }

        //Details
        [AllowAnonymous]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = _articles.FirstOrDefault(a => a.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            // Increment view count
            article.Num_of_views++;

            return View(article);
        }

        //create
        [Authorize(Roles = "Doctor")]
        public IActionResult Create()
        {
            return View();
        }

        //create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Doctor")]
        public IActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                // Set current user as author
                var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                if (currentUser == null)
                {
                    return NotFound("User not found");
                }

                article.Id = _articles.Any() ? _articles.Max(a => a.Id) + 1 : 1;
                article.UserId = currentUser.Id;
                article.publishDate = DateTime.Now.ToString("yyyy-MM-dd");
                article.Num_of_views = 0;

                // Set default author image if not provided
                if (string.IsNullOrEmpty(article.authorImage))
                {
                    article.authorImage = "/img/default-author.jpg";
                }

                _articles.Add(article);
                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }

        //edit
        [Authorize(Roles = "Doctor")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = _articles.FirstOrDefault(a => a.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            // Check if user owns the article
            var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (article.UserId != currentUser.Id)
            {
                return Forbid("You can only edit your own articles");
            }

            return View(article);
        }

        // POST:Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Doctor")]
        public IActionResult Edit(int id, Article article)
        {
            if (id != article.Id)
            {
                return NotFound();
            }

            // Check if user owns the article
            var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (article.UserId != currentUser.Id)
            {
                return Forbid("You can only edit your own articles");
            }

            if (ModelState.IsValid)
            {
                var existingArticle = _articles.FirstOrDefault(a => a.Id == id);
                if (existingArticle == null)
                {
                    return NotFound();
                }

                existingArticle.Title = article.Title;
                existingArticle.Description = article.Description;
                existingArticle.category = article.category;
                existingArticle.authorImage = article.authorImage;

                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }

        // GET: Delete
        [Authorize(Roles = "Doctor")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = _articles.FirstOrDefault(a => a.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            // Check if user owns the article
            var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (article.UserId != currentUser.Id)
            {
                return Forbid("You can only delete your own articles");
            }

            return View(article);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Doctor")]
        public IActionResult DeleteConfirmed(int id)
        {
            var article = _articles.FirstOrDefault(a => a.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            // Check if user owns the article
            var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (article.UserId != currentUser.Id)
            {
                return Forbid("You can only delete your own articles");
            }

            _articles.Remove(article);
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _articles.Any(e => e.Id == id);
        }

        // AJAX: Get articles by category
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetByCategory(string category)
        {
            var articles = _articles
                .Where(a => a.category == category)
                .OrderByDescending(a => a.publishDate)
                .Take(6)
                .ToList();

            return PartialView("_ArticlesPartial", articles);
        }

        // AJAX: Search articles
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Search(string term)
        {
            var articles = _articles
                .Where(a => a.Title.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                           a.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(a => a.publishDate)
                .Take(10)
                .ToList();

            return PartialView("_ArticlesPartial", articles);
        }
    }
}