using Nurse_IQ.Data;
using Nurse_IQ.Enums.Course;
using Nurse_IQ.Enums.User;
using Nurse_IQ.Models;
using System;
using System.Numerics;

namespace Nurse_IQ.Data
{
    public static class SeedData
    {
        public static readonly applicationUser[] Users =
        {
            new applicationUser
            {
                Id = 1,
                Fname = "Ahmed",
                Lname = "Ali",
                gender = gender.male,
                role = role.Student,
                BirthDate = new DateTime(2000, 1, 1),
                Educational_institution = "Cairo University",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                Year_Level = YearLevel.First_Year,
                interests_Fields = new List<string>{ "Nursing", "Emergency", "ICU" }
            },
            new applicationUser
            {
                Id = 2,
                Fname = "Mona",
                Lname = "Hassan",
                gender = gender.female,
                role = role.Doctor,
                BirthDate = new DateTime(1985, 5, 20),
                Educational_institution = "Ain Shams University",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string>{ "Pediatrics", "Cardiology" }
            }
        };

        public static readonly Course[] Courses =
        {
            new Course
            {
                Id = 1,
                Name = "Anatomy",
                Title = "Human Anatomy",
                YearLevel = CourseYearLevel.First_Year,
                courseType = CourseType.theoretical_Course,
                semister = CourseSemester.FirstSemester,
                Duration = "3 months",
                imageUrl = "anatomy.jpg",
                smallDescription = "Intro to Anatomy",
                bigDescription = "Detailed study of human anatomy...",
                courseTopics = new List<string> { "Bones", "Muscles", "Organs" },
                courseRequizetes = new List<string> { "Biology Basics" },
                UserId = 2 // Doctor Mona teaches this
            }
        };

        public static readonly Lecture[] Lectures =
        {
            new Lecture
            {
                Id = 1,
                Title = "Skeletal System",
                smallDescription = "Intro to bones",
                bigDescription = "Detailed structure of bones",
                duration = "45 min",
                videoUrl = "skeletal.mp4",
                CourseId = 1,
                UserId = 2 // Doctor Mona
            },
            new Lecture
            {
                Id = 2,
                Title = "neural System",
                smallDescription = "Intro to neurals",
                bigDescription = "Detailed structure of neural",
                duration = "55 min",
                videoUrl = "skeletal.mp4",
                CourseId = 1,
                UserId = 2 // Doctor Mona
            }
        };

        public static readonly LectureMaterial[] LectureMaterials =
        {
            new LectureMaterial
            {
                Id = 1,
                FileName = "Bones.pdf",
                FileUrl = "materials/bones.pdf",
                LectureId = 1
            }
        };

        public static readonly Quiz[] quizzes = new[]
        {
            new Quiz
            {
                Id = 1,
                Title = "Bones Quiz",
                LectureId = 1,
                UserId=1
            },
             new Quiz
            {
                Id = 2,
                Title = "Ethics Quiz",
                LectureId = 2,
                UserId = 1
            }
        };

        public static readonly Article[] Articles = new[]
        {
                new Article
                {
                    Id = 1,
                    Title = "Nursing in ICU",
                    Description = "Challenges in ICU nursing",
                    category = "Medical",
                    autorImage = "doctor1.png",
                    publisheDate = DateTime.Now.ToShortDateString(),
                    readTime = "5 min",
                    Num_of_views = 100,
                    UserId = 2
                },
                new Article
                {
                Id = 2,
                Title = "Emergency Care",
                Description = "Handling ER cases",
                category = "Medical",
                autorImage = "doctor1.png",
                publisheDate = DateTime.Now.ToShortDateString(),
                readTime = "6 min",
                Num_of_views = 150,
                UserId = 2
                }
        };

        public static readonly Announcement[] Announcements = new[]
        {
            new Announcement
            {
                Id = 1,
                Title = "Exam Schedule",
                Content = "Midterm exams will start next week.",
                Date = DateTime.Now,
                CreatedByAdminId = 2
            },
            new Announcement
            {
                Id = 2,
                Title = "Holiday Notice",
                Content = "The college will be closed next Friday.",
                Date = DateTime.Now,
                CreatedByAdminId = 1
            }
        };

        public static readonly Offer[] Offers = new[]
        {
            new Offer { Id = 1, OriginalPrice = 100, DiscountPrice = 80, LastPrice = 80, discountPercentage = 20 },
            new Offer { Id = 2, OriginalPrice = 200, DiscountPrice = 150, LastPrice = 150, discountPercentage = 25 }
        };

        public static readonly Diploma[] Diplomas = new[]
        {
            new Diploma { ID = 1, Title = "Critical Care Diploma", Description = "Advanced diploma for ICU nurses", Duration = "6 months" },
            new Diploma { ID = 2, Title = "Pediatrics Diploma", Description = "Specialized training for pediatric nurses", Duration = "8 months" }
        };

        public static readonly ContactForm[] ContactForms = new[]
        {
            new ContactForm { ID = 1, FullName = "Ahmed mohamed", email = "ahmed@example.com", message = "Need help with registration." },
            new ContactForm { ID = 2, FullName = "Mona esmail", email = "mona@example.com", message = "Issue with course enrollment." }
        };

        public static readonly MedicalTerm[] MedicalTerms = new[]
        {
            new MedicalTerm { Id = 1, arabicName = "قلب", englishName = "Heart", latinName = "Cor", category = "Organ", example = "The heart pumps blood", synonyms = new List<string> { "Cardiac" } },
            new MedicalTerm { Id = 2, arabicName = "دم", englishName = "Blood", latinName = "Sanguis", category = "Fluid", example = "Blood carries oxygen", synonyms = new List<string> { "Hemato" } }
        };

        public static readonly Medicine[] Medicines = new[]
        {
            new Medicine { Id = 1, englishName = "Paracetamol", category = "Analgesic", description = "Used for pain relief" },
            new Medicine { Id = 2, englishName = "Amoxicillin", category = "Antibiotic", description = "Used for bacterial infections" }
        };

        public static readonly Forumtopic[] Forumtopics = new[]
        {
            new Forumtopic { Id = 1, Title = "Best ways to study anatomy?", Description = "What tips do you use?",  UserId = 1 },
            new Forumtopic { Id = 2, Title = "How to prepare for OSCE?", Description = "Any strategies?",  UserId = 2 }
        };


        public static readonly Training[] Trainings = new[]
        {
                new Training
                {
                    Id = 1,
                    Title = "Basic Life Support",
                    Description = "CPR and emergency response",
                     postedDate= DateTime.Now,
                    deadline = DateTime.Now.AddMonths(1),
                    imageUrl = "bls.png",
                    salary = 0
                }
        };

        public static readonly UserRegisteredTraining[] UserRegisteredTrainings = new[]
        {
                new UserRegisteredTraining
                {
                    TrainingId = 1,
                    UserId = 1
                }
        };

        public static readonly DiplomaFeature[] DiplomaFeatures = new[]
       {
            new DiplomaFeature
            {
                Id = 1,
                Title = "Hands-on ICU Training",
                Description = "Practical training in intensive care unit",
                DiplomaId = 1
            },
            new DiplomaFeature
            {
                Id = 2,
                Title = "Certified Instructors",
                Description = "All courses are taught by certified doctors",
                DiplomaId = 1
            },
            new DiplomaFeature
            {
                Id = 3,
                Title = "Pediatric Focus",
                Description = "Special content for child care",
                DiplomaId = 2
            }
        };

        public static readonly training_video[] TrainingVideos = new[]
        {
            new training_video
            {
                Id = 1,
                Title = "Injection Techniques",
                Description = "Learn safe injection practices",
                videoUrl = "videos/injection.mp4",
                CreatedByAdminId = 2
            },
            new training_video
            {
                Id = 2,
                Title = "Wound Dressing",
                Description = "Step by step wound dressing guide",
                videoUrl = "videos/dressing.mp4",

                CreatedByAdminId =2
            },
            new training_video
            {
                Id = 3,
                Title = "Patient Communication",
                Description = "How to talk with patients effectively",
                videoUrl = "videos/communication.mp4",
                CreatedByAdminId = 2
            }
        };

        public static readonly Question[] Questions = new[]
        {
            new Question
            {
                Id = 1,
                Text = "What is the normal heart rate?",
                options = new List<string> { "60-100 bpm", "40-60 bpm", "100-120 bpm", "120-140 bpm" },
                CorrectAnswer = "60-100 bpm",
                QuizId = 1
            },
            new Question
            {
                Id = 2,
                Text = "Which bone is the largest in the human body?",
                options = new List<string> { "Femur", "Tibia", "Humerus", "Pelvis" },
                CorrectAnswer = "Femur",
                QuizId = 1
            },
            new Question
            {
                Id = 3,
                Text = "Which principle is part of nursing ethics?",
                options = new List<string> { "Confidentiality", "Negligence", "Abandonment", "Dishonesty" },
                CorrectAnswer = "Confidentiality",
                QuizId = 2
            }

        };
    }
}






