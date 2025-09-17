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
    public class OffersController : Controller
    {
        private static readonly List<Offer> _offers = SeedData.Offers.ToList();
        private static readonly List<applicationUser> _users = SeedData.Users.ToList();

        [AllowAnonymous]
        public IActionResult Index(string? category = null, string? search = null)
        {
            var offersQuery = _offers.Where(o => o.IsValid()).AsQueryable();

            if (!string.IsNullOrEmpty(category) && category != "all")
                offersQuery = offersQuery.Where(o => o.category.Equals(category, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(search))
                offersQuery = offersQuery.Where(o =>
                    o.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    o.SubTitle.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    o.Description.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    o.category.Contains(search, StringComparison.OrdinalIgnoreCase));

            var offers = offersQuery.OrderByDescending(o => o.expiredAt)
                .Select(o => new Offer
                {
                    Id = o.Id,
                    Title = o.Title,
                    SubTitle = o.SubTitle,
                    category = o.category,
                    Description = o.Description,
                    OriginalPrice = o.OriginalPrice,
                    DiscountPercentage = o.DiscountPercentage,
                    imageUrl = o.imageUrl,
                    expiredAt = o.expiredAt,
                    features = o.features,
                    CreatedByAdminId = o.CreatedByAdminId,
                    CreatedBy = _users.FirstOrDefault(u => u.Id == o.CreatedByAdminId) ?? new applicationUser { UserName = "Unknown" }
                })
                .ToList();

            ViewBag.Categories = _offers.Select(o => o.category).Distinct().ToList();
            ViewBag.CurrentCategory = category;
            ViewBag.SearchTerm = search;

            var featuredOffer = _offers
                .Where(o => o.IsValid())
                .OrderByDescending(o => o.DiscountPercentage)
                .Select(o => new Offer
                {
                    Id = o.Id,
                    Title = o.Title,
                    SubTitle = o.SubTitle,
                    category = o.category,
                    Description = o.Description,
                    OriginalPrice = o.OriginalPrice,
                    DiscountPercentage = o.DiscountPercentage,
                    imageUrl = o.imageUrl,
                    expiredAt = o.expiredAt,
                    features = o.features,
                    CreatedByAdminId = o.CreatedByAdminId,
                    CreatedBy = _users.FirstOrDefault(u => u.Id == o.CreatedByAdminId) ?? new applicationUser { UserName = "Unknown" }
                })
                .FirstOrDefault();

            ViewBag.FeaturedOffer = featuredOffer;
            return View(offers);
        }

        [AllowAnonymous]
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var offer = _offers.FirstOrDefault(o => o.Id == id && o.IsValid());
            if (offer == null) return NotFound();

            offer.CreatedBy = _users.FirstOrDefault(u => u.Id == offer.CreatedByAdminId) ?? new applicationUser { UserName = "Unknown" };
            return View(offer);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Offer offer, string featuresInput)
        {
            if (ModelState.IsValid)
            {
                var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                if (currentUser == null) return NotFound("User not found");

                offer.Id = _offers.Any() ? _offers.Max(o => o.Id) + 1 : 1;
                offer.CreatedByAdminId = currentUser.Id;
                offer.features = string.IsNullOrEmpty(featuresInput)
                    ? new List<string>()
                    : featuresInput.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(f => f.Trim()).ToList();
                if (string.IsNullOrEmpty(offer.imageUrl)) offer.imageUrl = "/img/default-offer.jpg";

                _offers.Add(offer);
                return RedirectToAction(nameof(Index));
            }
            return View(offer);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var offer = _offers.FirstOrDefault(o => o.Id == id && o.IsValid());
            if (offer == null) return NotFound();
            if (!User.IsInRole("Admin")) return Forbid();

            offer.CreatedBy = _users.FirstOrDefault(u => u.Id == offer.CreatedByAdminId) ?? new applicationUser { UserName = "Unknown" };
            return View(offer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id, Offer offer, string featuresInput)
        {
            if (id != offer.Id) return NotFound();
            if (!User.IsInRole("Admin")) return Forbid();

            if (ModelState.IsValid)
            {
                var existingOffer = _offers.FirstOrDefault(o => o.Id == id);
                if (existingOffer == null) return NotFound();

                existingOffer.Title = offer.Title;
                existingOffer.SubTitle = offer.SubTitle;
                existingOffer.Description = offer.Description;
                existingOffer.category = offer.category;
                existingOffer.OriginalPrice = offer.OriginalPrice;
                existingOffer.DiscountPercentage = offer.DiscountPercentage;
                existingOffer.features = string.IsNullOrEmpty(featuresInput)
                    ? new List<string>()
                    : featuresInput.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(f => f.Trim()).ToList();
                existingOffer.imageUrl = offer.imageUrl;
                existingOffer.expiredAt = offer.expiredAt;

                return RedirectToAction(nameof(Index));
            }
            return View(offer);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var offer = _offers.FirstOrDefault(o => o.Id == id && o.IsValid());
            if (offer == null) return NotFound();
            if (!User.IsInRole("Admin")) return Forbid();

            offer.CreatedBy = _users.FirstOrDefault(u => u.Id == offer.CreatedByAdminId) ?? new applicationUser { UserName = "Unknown" };
            return View(offer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteConfirmed(int id)
        {
            var offer = _offers.FirstOrDefault(o => o.Id == id);
            if (offer == null) return NotFound();
            if (!User.IsInRole("Admin")) return Forbid();

            _offers.Remove(offer);
            return RedirectToAction(nameof(Index));
        }

        private bool OfferExists(int id)
        {
            return _offers.Any(e => e.Id == id);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetByCategory(string category)
        {
            if (string.IsNullOrEmpty(category)) return BadRequest();

            var offers = _offers
                .Where(o => o.category.Equals(category, StringComparison.OrdinalIgnoreCase) && o.IsValid())
                .OrderByDescending(o => o.expiredAt)
                .Take(6)
                .Select(o => new Offer
                {
                    Id = o.Id,
                    Title = o.Title,
                    SubTitle = o.SubTitle,
                    category = o.category,
                    Description = o.Description,
                    OriginalPrice = o.OriginalPrice,
                    DiscountPercentage = o.DiscountPercentage,
                    imageUrl = o.imageUrl,
                    expiredAt = o.expiredAt,
                    features = o.features,
                    CreatedByAdminId = o.CreatedByAdminId,
                    CreatedBy = _users.FirstOrDefault(u => u.Id == o.CreatedByAdminId) ?? new applicationUser { UserName = "Unknown" }
                })
                .ToList();

            return PartialView("_OffersPartial", offers);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Search(string term)
        {
            if (string.IsNullOrEmpty(term)) return BadRequest();

            var offers = _offers
                .Where(o => o.IsValid() && (
                    o.Title.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                    o.SubTitle.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                    o.Description.Contains(term, StringComparison.OrdinalIgnoreCase)))
                .OrderByDescending(o => o.expiredAt)
                .Take(10)
                .Select(o => new Offer
                {
                    Id = o.Id,
                    Title = o.Title,
                    SubTitle = o.SubTitle,
                    category = o.category,
                    Description = o.Description,
                    OriginalPrice = o.OriginalPrice,
                    DiscountPercentage = o.DiscountPercentage,
                    imageUrl = o.imageUrl,
                    expiredAt = o.expiredAt,
                    features = o.features,
                    CreatedByAdminId = o.CreatedByAdminId,
                    CreatedBy = _users.FirstOrDefault(u => u.Id == o.CreatedByAdminId) ?? new applicationUser { UserName = "Unknown" }
                })
                .ToList();

            return PartialView("_OffersPartial", offers);
        }
    }
}
