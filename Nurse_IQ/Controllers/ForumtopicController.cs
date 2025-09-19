using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Data;
using Nurse_IQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nurse_IQ.Controllers
{
    [Authorize]
    public class ForumController : Controller
    {
        private static readonly List<Forumtopic> _forumTopics = SeedData.Forumtopics.ToList();
        private static readonly List<applicationUser> _users = SeedData.Users.ToList();

        // GET: Forum
        [AllowAnonymous]
        public IActionResult Index(string? category = null, string? search = null, string? sort = "latest")
        {
            var forumTopicsQuery = _forumTopics.AsQueryable();

            // Filter by category
            if (!string.IsNullOrEmpty(category) && category != "all")
            {
                forumTopicsQuery = forumTopicsQuery.Where(ft => ft.category == category);
            }

            // Search
            if (!string.IsNullOrEmpty(search))
            {
                forumTopicsQuery = forumTopicsQuery.Where(ft =>
                    ft.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    ft.Description.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    ft.category.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            // Sort
            switch (sort)
            {
                case "popular":
                    forumTopicsQuery = forumTopicsQuery.OrderByDescending(ft => ft.num_of_views);
                    break;
                case "replies":
                    forumTopicsQuery = forumTopicsQuery.OrderByDescending(ft => ft.num_comments);
                    break;
                case "latest":
                default:
                    forumTopicsQuery = forumTopicsQuery.OrderByDescending(ft => ft.Id);
                    break;
            }

            var forumTopics = forumTopicsQuery.ToList();

            // Pass categories for filter dropdown
            ViewBag.Categories = _forumTopics.Select(ft => ft.category).Distinct().ToList();
            ViewBag.CurrentCategory = category;
            ViewBag.SearchTerm = search;
            ViewBag.CurrentSort = sort;

            return View(forumTopics);
        }

        // GET: Details
        [AllowAnonymous]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forumTopic = _forumTopics.FirstOrDefault(ft => ft.Id == id);
            if (forumTopic == null)
            {
                return NotFound();
            }

            // Attach user to topic
            forumTopic.User = _users.FirstOrDefault(u => u.Id == forumTopic.UserId);

            // Increment view count
            forumTopic.num_of_views++;

            return View(forumTopic);
        }

        // GET: Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Forumtopic forumTopic)
        {
            if (ModelState.IsValid)
            {
                var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                if (currentUser == null)
                {
                    return NotFound("User not found");
                }

                forumTopic.Id = _forumTopics.Any() ? _forumTopics.Max(ft => ft.Id) + 1 : 1;
                forumTopic.UserId = currentUser.Id;
                forumTopic.User = currentUser;
                forumTopic.comments = new List<string>();
                forumTopic.num_of_likes = 0;
                forumTopic.num_of_views = 0;

                _forumTopics.Add(forumTopic);
                return RedirectToAction(nameof(Index));
            }
            return View(forumTopic);
        }

        // AJAX: Add comment to topic
        [HttpPost]
        public IActionResult AddComment(int topicId, string comment)
        {
            var forumTopic = _forumTopics.FirstOrDefault(ft => ft.Id == topicId);
            if (forumTopic == null)
            {
                return NotFound();
            }

            var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (currentUser == null)
            {
                return Unauthorized();
            }

            forumTopic.comments.Add($"{currentUser.UserName}: {comment}");
            forumTopic.num_comments = forumTopic.comments.Count;

            return Ok();
        }

        // AJAX: Like topic
        [HttpPost]
        public IActionResult LikeTopic(int topicId)
        {
            var forumTopic = _forumTopics.FirstOrDefault(ft => ft.Id == topicId);
            if (forumTopic == null)
            {
                return NotFound();
            }

            forumTopic.num_of_likes++;
            return Ok(new { likes = forumTopic.num_of_likes });
        }

        // AJAX: Get topics by category
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetByCategory(string category, string sort = "latest")
        {
            var forumTopicsQuery = _forumTopics.AsQueryable();

            if (!string.IsNullOrEmpty(category) && category != "all")
            {
                forumTopicsQuery = forumTopicsQuery.Where(ft => ft.category == category);
            }

            // Sort
            switch (sort)
            {
                case "popular":
                    forumTopicsQuery = forumTopicsQuery.OrderByDescending(ft => ft.num_of_views);
                    break;
                case "replies":
                    forumTopicsQuery = forumTopicsQuery.OrderByDescending(ft => ft.num_comments);
                    break;
                case "latest":
                default:
                    forumTopicsQuery = forumTopicsQuery.OrderByDescending(ft => ft.Id);
                    break;
            }

            var forumTopics = forumTopicsQuery.Take(6).ToList();
            return PartialView("_ForumTopicsPartial", forumTopics);
        }

        // AJAX: Search topics
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Search(string term, string sort = "latest")
        {
            var forumTopicsQuery = _forumTopics.AsQueryable();

            if (!string.IsNullOrEmpty(term))
            {
                forumTopicsQuery = forumTopicsQuery.Where(ft =>
                    ft.Title.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                    ft.Description.Contains(term, StringComparison.OrdinalIgnoreCase));
            }

            // Sort
            switch (sort)
            {
                case "popular":
                    forumTopicsQuery = forumTopicsQuery.OrderByDescending(ft => ft.num_of_views);
                    break;
                case "replies":
                    forumTopicsQuery = forumTopicsQuery.OrderByDescending(ft => ft.num_comments);
                    break;
                case "latest":
                default:
                    forumTopicsQuery = forumTopicsQuery.OrderByDescending(ft => ft.Id);
                    break;
            }

            var forumTopics = forumTopicsQuery.Take(10).ToList();
            return PartialView("_ForumTopicsPartial", forumTopics);
        }
    }
}
