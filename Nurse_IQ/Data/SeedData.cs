using Microsoft.AspNetCore.Identity;
using Nurse_IQ.Data;
using Nurse_IQ.Enums.ContactForm;
using Nurse_IQ.Enums.Course;
using Nurse_IQ.Enums.Question;
using Nurse_IQ.Enums.User;
using Nurse_IQ.Models;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Numerics;
namespace Nurse_IQ.Data
{
    public static class SeedData
    {
    

        // ================= Users =================

        public static readonly applicationUser[] Users = new[]
            {
            new applicationUser
            {
                Id =1,
                UserName = "admin",               
                NormalizedUserName = "ADMIN",
                Email = "admin@nurseiq.com",
                NormalizedEmail = "ADMIN@NURSEIQ.COM",
                Fname = "System",
                Lname = "Admin",
                gender = gender.male,
                role = role.Student,
                BirthDate = new DateTime(1990, 1, 1),
                Educational_institution = "Nursing Faculty",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string> { "Research", "Teaching" },
                PasswordHash ="AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()               //
            },
            new applicationUser
            {
                Id = 2,
                UserName = "doctor1",
                NormalizedUserName = "DOCTOR1",
                Email = "doctor1@nurseiq.com",
                NormalizedEmail = "DOCTOR1@NURSEIQ.COM",
                Fname = "Ahmed",
                Lname = "Ali",
                gender = gender.male,
                role = role.Doctor,
                BirthDate = new DateTime(1985, 6, 12),
                Educational_institution = "Cairo University",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string> { "Pharmacology", "ICU", "Pediatrics" }, 
                PasswordHash = "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()
            }
        };

            // ================= Courses =================
            public static readonly Course[] Courses = new[]
            {
            new Course
            {
                Id = 1,
                Name = "Fundamentals of Nursing",
                Title = "Basics of patient care",
                YearLevel = CourseYearLevel.First_Year,
                courseType = CourseType.theoretical_Course,
                semister = CourseSemester.FirstSemester,
                Duration = "3 Months",
                imageUrl = "img/course1.jpg",
                smallDescription = "Intro to nursing",
                bigDescription = "Comprehensive intro to nursing practice",
                courseTopics = new List<string> { "Patient Safety", "Ethics", "ICU Basics" },
                courseRequizetes = new List<string> { "High school diploma" },
                UserId = 2
            },
            new Course
            {
                Id = 2,
                Name = "Pharmacology",
                Title = "Introduction to drugs",
                YearLevel = CourseYearLevel.Second_Year,
                courseType = CourseType.theoretical_Course,
                semister = CourseSemester.FirstSemester,
                Duration = "4 Months",
                imageUrl = "img/course2.jpg",
                smallDescription = "Basic pharmacology",
                bigDescription = "Drug classes and their uses",
                courseTopics = new List<string> { "Antibiotics", "Analgesics" },
                courseRequizetes = new List<string> { "Biology basics" },
                UserId = 2
            }
        };

            // ================= Articles =================
            public static readonly Article[] Articles = new[]
            {
            new Article
            {
                Id = 1,
                Title = "Nursing in ICU",
                Description = "Challenges in ICU nursing",
                imageUrl = "img/article1.jpg",
                category = "Medical",
                autorImage = "img/doctor1.png",
                publisheDate = "2025-09-13",
                readTime = "7 min",
                Num_of_views = 100,
                UserId = 2
            },
            new Article
            {
                Id = 2,
                Title = "Pharmacology Basics",
                Description = "Essential knowledge of drug mechanisms",
                imageUrl = "img/article2.jpg",
                category = "Pharma",
                autorImage = "img/doctor2.png",
                publisheDate ="2025-11-13",
                readTime = "7 min",
                Num_of_views = 150,
                UserId = 2
            }
        };

            // ================= Announcements =================
            public static readonly Announcement[] Announcements = new[]
            {
            new Announcement
            {
                Id = 1,
                Title = "Welcome",
                Content = "Welcome to NursingIQ!",
                Date = new DateTime(2025, 9, 13),
                category = "General",
                AdminImageUrl = "img/admin.png",
                CreatedByAdminId = 1
            },
            new Announcement
            {
                Id = 2,
                Title = "New Courses",
                Content = "We have launched new nursing courses",
                Date = new DateTime(2025, 5, 10),
                category = "Update",
                AdminImageUrl = "img/admin.png",
                CreatedByAdminId = 1
            }
        };

            // ================= ContactForms =================
            public static readonly ContactForm[] ContactForms = new[]
            {
            new ContactForm
            {
                ID = 1,
                FullName = "Mohamed Ali",
                phone = "01012345678",
                email = "mohamed@example.com",
                InquiryType = InquiryType.TechnicalProblem,
                message = "I want to know more about NursingIQ",
                CreatedByAdminId = 1
            },
            new ContactForm
            {
                ID = 2,
                FullName = "Sara Ahmed",
                phone = "01098765432",
                email = "sara@example.com",
                InquiryType = InquiryType.PaymentProblem,
                message = "I have an issue logging in",
                CreatedByAdminId = 1
            }
        };

            // ================= Diplomas =================
            public static readonly Diploma[] Diplomas = new[]
            {

            new Diploma
            {
                ID = 1,
                Title = "ICU Nursing Diploma",
                Description = "Specialized training for ICU nurses",
                Duration = "6 Months",
                requirement = new List<string> { "Nursing Degree", "2 Years Experience" },
                register_steps = new List<string> { "Apply Online", "Submit Documents", "Pay Fees" },
                CreatedByAdminId = 1
            },
            new Diploma
            {
                ID = 2,
                Title = "Pediatric Nursing Diploma",
                Description = "Care for children and infants",
                Duration = "4 Months",
                requirement = new List<string> { "Nursing Degree" },
                register_steps = new List<string> { "Apply Online", "Attend Interview" },
                CreatedByAdminId = 1
            }
        };

            public static readonly DiplomaFeature[] DiplomaFeatures = new[]
            {

            new DiplomaFeature
            {
                Id = 1,
                Title = "Hands-on ICU Training",
                Description = "Practical training in intensive care unit",
                Icon = "icon-icu.png",
                DiplomaId = 1
            },
            new DiplomaFeature
            {
                Id = 2,
                Title = "Certified Instructors",
                Description = "All courses are taught by certified doctors",
                Icon = "icon-doctor.png",
                DiplomaId = 1
            },
            new DiplomaFeature
            {
                Id = 3,
                Title = "Pediatric Focus",
                Description = "Special content for child care",
                Icon = "icon-child.png",
                DiplomaId = 2
            }
        };

            // ================= Forum Topics =================
            public static readonly Forumtopic[] Forumtopics = new[]
            {
            new Forumtopic
            {
                Id = 1,
                Title = "How to study nursing effectively?",
                Description = "Share your study tips here",
                category = "Study",
                comments = new List<string> { "Use flashcards", "Group study works well" },
                num_of_likes = 10,
                num_of_views = 200,
                UserId = 2
            },
            new Forumtopic
            {
                Id = 2,
                Title = "Best resources for pharmacology",
                Description = "Discuss the best books and notes",
                category = "Pharma",
                comments = new List<string> { "Katzung's Pharmacology", "Local notes" },
                num_of_likes = 20,
                num_of_views = 300,
                UserId = 2
            }
        };

            // ================= Medical Terms =================
            public static readonly MedicalTerm[] MedicalTerms = new[]
            {
                       new MedicalTerm
            {
                Id = 1,
                arabicName = "قلب",
                englishName = "Heart",
                latinName = "Cor",
                category = "Anatomy",
                example = "The heart pumps blood",
                synonyms = new List<string> { "Cardiac", "Cardio" },
                UserId = 2
            },
            new MedicalTerm
            {
                Id = 2,
                arabicName = "رئة",
                englishName = "Lung",
                latinName = "Pulmo",
                category = "Anatomy",
                example = "The lung helps breathing",
                synonyms = new List<string> { "Pulmonary" },
                UserId = 2
            }
        };

            // ================= Medicines =================
            public static readonly Medicine[] Medicines = new[]
            {

            new Medicine
            {
                Id = 1,
                arabicName = "باراسيتامول",
                englishName = "Paracetamol",
                latinName = "Acetaminophen",
                category = "Analgesic",
                form = "Tablet",
                description = "Pain relief",
                indications = "Fever, Pain",
                sideEffects = "Nausea, Rash",
                dosage = "500mg",
                UserId = 2
            },
            new Medicine
            {
                Id = 2,
                arabicName = "أموكسيسيلين",
                englishName = "Amoxicillin",
                latinName = "Amoxicillinum",
                category = "Antibiotic",
                form = "Capsule",
                description = "Bacterial infections",
                indications = "Infections",
                sideEffects = "Diarrhea, Allergic reaction",
                dosage = "250mg",
                UserId = 2
            }
        };

            // ================= Offers =================
            public static readonly Offer[] Offers = new[]
            {
                        new Offer
            {
                Id = 1,
                Title = "ICU Training Offer",
                SubTitle = "Save 20%",
                category = "Training",
                Description = "Discount on ICU diploma",
                OriginalPrice = 1000,
                discountPercentage = 20,
                imageUrl = "img/offer1.png",
                expiredAt = new DateTime(2025, 9, 5),
                features = new List<string> { "Practical Sessions", "Certified Trainers" },
                CreatedByAdminId = 1
            },
            new Offer
            {
                Id = 2,
                Title = "Pharma Course Offer",
                SubTitle = "Save 10%",
                category = "Course",
                Description = "Discount on Pharmacology course",
                OriginalPrice = 500,
                discountPercentage = 10,
                imageUrl = "img/offer2.png",
                expiredAt =new DateTime(2025, 7, 1),
                features = new List<string> { "Free Materials", "Extra Practice" },
                CreatedByAdminId = 1
            }
        };

            // ================= Trainings =================
            public static readonly Training[] Trainings = new[]
            {
           new Training
            {
                Id = 1,
                Title = "ICU Training",
                HospitalName = "Cairo Hospital",
                Location = "Cairo",
                Category = "ICU",
                salary = 5000,
                Experience = "2 Years",
                requirement = new List<string> { "ICU Experience", "Nursing Degree" },
                Description = "Intensive care training",
                imageUrl = "img/training1.png",
                postedDate = new DateTime(2025, 9, 13),
                deadline = new DateTime(2025, 9, 13),
                CreatedByAdminId = 1
            },
            new Training
            {
                Id = 2,
                Title = "Pediatrics Training",
                HospitalName = "Children’s Hospital",
                Location = "Giza",
                Category = "Pediatrics",
                salary = 4000,
                Experience = "1 Year",
                requirement = new List<string> { "Pediatric Experience" },
                Description = "Training in pediatrics ward",
                imageUrl = "img/training2.png",
                postedDate = new DateTime(2025, 9, 13),
                deadline = new DateTime(2025, 9, 20),
                CreatedByAdminId = 1
            }
        };

            public static readonly UserRegisteredTraining[] UserRegisteredTrainings = new[]
            {
            new UserRegisteredTraining { UserId = 2, TrainingId = 1 },
            new UserRegisteredTraining { UserId = 2, TrainingId = 2 }
        };

            // ================= Training Videos =================
            public static readonly training_video[] TrainingVideos = new[]
            {
            new training_video
            {
                Id = 1,
                Title = "Injection Techniques",
                Description = "Learn safe injection practices",
                category = "Practical",
                duration = "15 min",
                publishedDate = "2025-09-13",
                videoUrl = "videos/injection.mp4",
                instructorName = "Dr. Ahmed",
                instructorImage = "img/doctor1.png",
                thumbnailUrl = "img/injection.png",
                CreatedByAdminId = 2
            },
            new training_video
            {
                Id = 2,
                Title = "Wound Dressing",
                Description = "Step by step wound dressing guide",
                category = "Practical",
                duration = "20 min",
                publishedDate = "2025-06-23",
                videoUrl = "videos/dressing.mp4",
                instructorName = "Dr. Ahmed",
                instructorImage = "img/doctor1.png",
                thumbnailUrl = "img/dressing.png",
                CreatedByAdminId = 2
            }
        };

            // ================= Quizzes & Questions =================
            public static readonly Quiz[] Quizzes = new[]
            {
            new Quiz
            {
                Id = 1,
                Title = "ICU Basics Quiz",
                CourseId = 1,
                LectureId = 1,
                UserId = 2
            },
            new Quiz
            {
                Id = 2,
                Title = "Pharma Quiz",
                CourseId = 2,
                LectureId = 2,
                UserId = 2
            }
        };

            public static readonly Question[] Questions = new[]
            {
                 new Question
            {
                Id = 1,
                hardnessType = hardnessType.easy,
                Text = "What does ICU stand for?",
                CorrectAnswer = "Intensive Care Unit",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "Intensive Care Unit", "Internal Care Unit", "International Care Unit" },
                QuizId = 1
            },
            new Question
            {
                Id = 2,
                hardnessType = hardnessType.medium,
                Text = "What is the main use of Paracetamol?",
                CorrectAnswer = "Pain relief",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "Pain relief", "Antibiotic", "Anti-inflammatory" },
                QuizId = 2
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

          
    }
}
