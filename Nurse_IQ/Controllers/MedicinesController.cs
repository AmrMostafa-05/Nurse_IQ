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
    public class MedicinesController : Controller
    {
        private static readonly List<Medicine> _medicines = SeedData.Medicines.ToList();
        private static readonly List<applicationUser> _users = SeedData.Users.ToList();

        // GET: Medicines
        [AllowAnonymous]
        public IActionResult Index(string? search = null, string? category = null, string? form = null, string? letter = null, string? sort = null)
        {
            var medicinesQuery = _medicines.AsQueryable();

            // Search filter
            if (!string.IsNullOrEmpty(search))
            {
                medicinesQuery = medicinesQuery.Where(m =>
                    m.arabicName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    m.englishName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    m.latinName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    m.description.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    m.indications.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            // Category filter
            if (!string.IsNullOrEmpty(category) && category != "all")
            {
                medicinesQuery = medicinesQuery.Where(m => m.category == category);
            }

            // Form filter
            if (!string.IsNullOrEmpty(form) && form != "all")
            {
                medicinesQuery = medicinesQuery.Where(m => m.form == form);
            }

            // Letter filter
            if (!string.IsNullOrEmpty(letter))
            {
                medicinesQuery = medicinesQuery.Where(m =>
                    m.arabicName.StartsWith(letter, StringComparison.OrdinalIgnoreCase) ||
                    m.englishName.StartsWith(letter, StringComparison.OrdinalIgnoreCase));
            }

            // Sorting
            switch (sort)
            {
                case "title-desc":
                    medicinesQuery = medicinesQuery.OrderByDescending(m => m.arabicName);
                    break;
                case "title-asc":
                default:
                    medicinesQuery = medicinesQuery.OrderBy(m => m.arabicName);
                    break;
            }

            var medicines = medicinesQuery.Select(m => new MedicineViewModel
            {
                Id = m.Id,
                arabicName = m.arabicName,
                englishName = m.englishName,
                latinName = m.latinName,
                category = m.category,
                form = m.form,
                description = m.description,
                indications = m.indications,
                sideEffects = m.sideEffects,
                dosage = m.dosage
            }).ToList();

            ViewBag.Categories = _medicines.Select(m => m.category).Distinct().ToList();
            ViewBag.Forms = _medicines.Select(m => m.form).Distinct().ToList();
            ViewBag.CurrentSearch = search;
            ViewBag.CurrentCategory = category;
            ViewBag.CurrentForm = form;
            ViewBag.CurrentLetter = letter;
            ViewBag.CurrentSort = sort;

            return View(medicines);
        }

        // AJAX: Search medicines
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Search(string term, string category, string form, string letter, string sort)
        {
            var medicinesQuery = _medicines.AsQueryable();

            // Apply filters
            if (!string.IsNullOrEmpty(term))
            {
                medicinesQuery = medicinesQuery.Where(m =>
                    m.arabicName.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                    m.englishName.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                    m.latinName.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                    m.description.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                    m.indications.Contains(term, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(category) && category != "all")
            {
                medicinesQuery = medicinesQuery.Where(m => m.category == category);
            }

            if (!string.IsNullOrEmpty(form) && form != "all")
            {
                medicinesQuery = medicinesQuery.Where(m => m.form == form);
            }

            if (!string.IsNullOrEmpty(letter))
            {
                medicinesQuery = medicinesQuery.Where(m =>
                    m.arabicName.StartsWith(letter, StringComparison.OrdinalIgnoreCase) ||
                    m.englishName.StartsWith(letter, StringComparison.OrdinalIgnoreCase));
            }

            // Sorting
            switch (sort)
            {
                case "title-desc":
                    medicinesQuery = medicinesQuery.OrderByDescending(m => m.arabicName);
                    break;
                case "title-asc":
                default:
                    medicinesQuery = medicinesQuery.OrderBy(m => m.arabicName);
                    break;
            }

            var medicines = medicinesQuery.Select(m => new MedicineViewModel
            {
                Id = m.Id,
                arabicName = m.arabicName,
                englishName = m.englishName,
                latinName = m.latinName,
                category = m.category,
                form = m.form,
                description = m.description,
                indications = m.indications,
                sideEffects = m.sideEffects,
                dosage = m.dosage
            }).ToList();

            return PartialView("_MedicinesPartial", medicines);
        }

        // GET: Details
        [AllowAnonymous]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicine = _medicines.FirstOrDefault(m => m.Id == id);
            if (medicine == null)
            {
                return NotFound();
            }

            var viewModel = new MedicineViewModel
            {
                Id = medicine.Id,
                arabicName = medicine.arabicName,
                englishName = medicine.englishName,
                latinName = medicine.latinName,
                category = medicine.category,
                form = medicine.form,
                description = medicine.description,
                indications = medicine.indications,
                sideEffects = medicine.sideEffects,
                dosage = medicine.dosage,
                UserName = _users.FirstOrDefault(u => u.Id == medicine.UserId)?.UserName ?? "Unknown"
            };

            return View(viewModel);
        }

        // GET: Create
        [Authorize(Roles = "Doctor")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Doctor")]
        public IActionResult Create(Medicine medicine)
        {
            if (ModelState.IsValid)
            {
                var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                if (currentUser == null)
                {
                    return NotFound("User not found");
                }

                medicine.Id = _medicines.Any() ? _medicines.Max(m => m.Id) + 1 : 1;
                medicine.UserId = currentUser.Id;

                _medicines.Add(medicine);
                return RedirectToAction(nameof(Index));
            }
            return View(medicine);
        }

        // GET:  Edit
        [Authorize(Roles = "Doctor")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicine = _medicines.FirstOrDefault(m => m.Id == id);
            if (medicine == null)
            {
                return NotFound();
            }

            var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (currentUser == null || medicine.UserId != currentUser.Id)
            {
                return Forbid("You can only edit your own medicines");
            }

            return View(medicine);
        }

        // POST:  Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Doctor")]
        public IActionResult Edit(int id, Medicine medicine)
        {
            if (id != medicine.Id)
            {
                return NotFound();
            }

            var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (currentUser == null || medicine.UserId != currentUser.Id)
            {
                return Forbid("You can only edit your own medicines");
            }

            if (ModelState.IsValid)
            {
                var existingMedicine = _medicines.FirstOrDefault(m => m.Id == id);
                if (existingMedicine == null)
                {
                    return NotFound();
                }

                existingMedicine.arabicName = medicine.arabicName;
                existingMedicine.englishName = medicine.englishName;
                existingMedicine.latinName = medicine.latinName;
                existingMedicine.description = medicine.description;
                existingMedicine.indications = medicine.indications;
                existingMedicine.category = medicine.category;
                existingMedicine.form = medicine.form;
                existingMedicine.sideEffects = medicine.sideEffects;
                existingMedicine.dosage = medicine.dosage;

                return RedirectToAction(nameof(Index));
            }
            return View(medicine);
        }

        // GET:  Delete
        [Authorize(Roles = "Doctor")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicine = _medicines.FirstOrDefault(m => m.Id == id);
            if (medicine == null)
            {
                return NotFound();
            }

            var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (currentUser == null || medicine.UserId != currentUser.Id)
            {
                return Forbid("You can only delete your own medicines");
            }

            return View(medicine);
        }

        // POST:  Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Doctor")]
        public IActionResult DeleteConfirmed(int id)
        {
            var medicine = _medicines.FirstOrDefault(m => m.Id == id);
            if (medicine == null)
            {
                return NotFound();
            }

            var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (currentUser == null || medicine.UserId != currentUser.Id)
            {
                return Forbid("You can only delete your own medicines");
            }

            _medicines.Remove(medicine);
            return RedirectToAction(nameof(Index));
        }

        private bool MedicineExists(int id)
        {
            return _medicines.Any(e => e.Id == id);
        }
    }
}