using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nurse_IQ.Data;
using Nurse_IQ.Models;
using Nurse_IQ.Enums.Question;

namespace Nurse_IQ.Controllers
{
    [Authorize]
    public class QuestionsController : Controller
    {
        private static readonly List<Quiz> _quizzes = SeedData.Quizzes.ToList();
        private static readonly List<applicationUser> _users = SeedData.Users.ToList();

        // GET:  TakeQuiz 
        public IActionResult TakeQuiz(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = _quizzes.FirstOrDefault(q => q.Id == id);
            if (quiz == null)
            {
                return NotFound();
            }

            // Shuffle questions server-side
            var questions = quiz.Questions.OrderBy(q => Guid.NewGuid()).ToList();
            quiz.Questions = questions;

            return View(quiz);
        }

        // POST:  SubmitQuiz
        [HttpPost]
        public IActionResult SubmitQuiz(int quizId, Dictionary<int, string> answers)
        {
            var quiz = _quizzes.FirstOrDefault(q => q.Id == quizId);
            if (quiz == null)
            {
                return Json(new { success = false, message = "الاختبار غير موجود" });
            }

            var currentUser = _users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (currentUser == null)
            {
                return Json(new { success = false, message = "المستخدم غير موجود" });
            }

            // Calculate results
            int correct = 0;
            int total = quiz.Questions.Count;
            int easyCorrect = 0, mediumCorrect = 0, hardCorrect = 0;
            int easyTotal = 0, mediumTotal = 0, hardTotal = 0;

            foreach (var question in quiz.Questions)
            {
                var studentAnswer = answers.ContainsKey(question.Id) ? answers[question.Id] : null;
                question.Student_Answer = studentAnswer;
                question.IsCorrect = studentAnswer != null && studentAnswer == question.CorrectAnswer;

                switch (question.hardnessType)
                {
                    case hardnessType.easy:
                        easyTotal++;
                        if (question.IsCorrect) easyCorrect++;
                        break;
                    case hardnessType.medium:
                        mediumTotal++;
                        if (question.IsCorrect) mediumCorrect++;
                        break;
                    case hardnessType.hard:
                        hardTotal++;
                        if (question.IsCorrect) hardCorrect++;
                        break;
                }

                if (question.IsCorrect)
                {
                    correct++;
                }
            }

            var percentage = total > 0 ? Math.Round((double)correct / total * 100) : 0;
            var result = new
            {
                success = true,
                correct,
                total,
                percentage,
                easyCorrect,
                easyTotal,
                mediumCorrect,
                mediumTotal,
                hardCorrect,
                hardTotal
            };

            return Json(result);
        }

        // POST:  ClearAnswers
        [HttpPost]
        public IActionResult ClearAnswers(int quizId)
        {
            var quiz = _quizzes.FirstOrDefault(q => q.Id == quizId);
            if (quiz == null)
            {
                return Json(new { success = false, message = "الاختبار غير موجود" });
            }

            foreach (var question in quiz.Questions)
            {
                question.Student_Answer = null;
                question.IsCorrect = false;
            }

            return Json(new { success = true, message = "تم مسح الإجابات بنجاح" });
        }
    }
}