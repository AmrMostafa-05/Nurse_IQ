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
            // Admin User
            new applicationUser
            {
                Id = 1,
                UserName = "admin",               
                NormalizedUserName = "ADMIN",
                Email = "admin@nurseiq.com",
                NormalizedEmail = "ADMIN@NURSEIQ.COM",
                Fname = "System",
                Lname = "Admin",
                gender = gender.male,
                role = role.Doctor,
                BirthDate = new DateTime(1990, 1, 1),
                Educational_institution = "Nursing Faculty",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string> { "Research", "Teaching", "Management" },
                PasswordHash = "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()
            },
            // Doctor Users
            new applicationUser
            {
                Id = 2,
                UserName = "doctor1",
                NormalizedUserName = "DOCTOR1",
                Email = "doctor1@nurseiq.com",
                NormalizedEmail = "DOCTOR1@NURSEIQ.COM",
                Fname = "أحمد",
                Lname = "علي",
                gender = gender.male,
                role = role.Doctor,
                BirthDate = new DateTime(1985, 6, 12),
                Educational_institution = "جامعة القاهرة",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string> { "Pharmacology", "ICU", "Pediatrics" }, 
                PasswordHash = "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new applicationUser
            {
                Id = 3,
                UserName = "doctor2",
                NormalizedUserName = "DOCTOR2",
                Email = "doctor2@nurseiq.com",
                NormalizedEmail = "DOCTOR2@NURSEIQ.COM",
                Fname = "فاطمة",
                Lname = "محمد",
                gender = gender.female,
                role = role.Doctor,
                BirthDate = new DateTime(1988, 3, 15),
                Educational_institution = "جامعة عين شمس",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string> { "Surgery", "Emergency", "Cardiology" },
                PasswordHash = "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new applicationUser
            {
                Id = 4,
                UserName = "doctor3",
                NormalizedUserName = "DOCTOR3",
                Email = "doctor3@nurseiq.com",
                NormalizedEmail = "DOCTOR3@NURSEIQ.COM",
                Fname = "محمد",
                Lname = "حسن",
                gender = gender.male,
                role = role.Doctor,
                BirthDate = new DateTime(1982, 8, 22),
                Educational_institution = "جامعة الإسكندرية",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string> { "Neurology", "Psychiatry", "Research" },
                PasswordHash = "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()
            },
            // Student Users
            new applicationUser
            {
                Id = 5,
                UserName = "student1",
                NormalizedUserName = "STUDENT1",
                Email = "student1@nurseiq.com",
                NormalizedEmail = "STUDENT1@NURSEIQ.COM",
                Fname = "سارة",
                Lname = "أحمد",
                gender = gender.female,
                role = role.Student,
                Year_Level = YearLevel.First_Year,
                BirthDate = new DateTime(2003, 5, 10),
                Educational_institution = "معهد التمريض العالي",
                Type_of_Educational_institution = Type_of_Edu_inst.institute,
                interests_Fields = new List<string> { "Pediatrics", "Emergency", "Community Health" },
                PasswordHash = "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new applicationUser
            {
                Id = 6,
                UserName = "student2",
                NormalizedUserName = "STUDENT2",
                Email = "student2@nurseiq.com",
                NormalizedEmail = "STUDENT2@NURSEIQ.COM",
                Fname = "علي",
                Lname = "محمود",
                gender = gender.male,
                role = role.Student,
                Year_Level = YearLevel.Sec_Year,
                BirthDate = new DateTime(2002, 12, 3),
                Educational_institution = "كلية التمريض - جامعة القاهرة",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string> { "ICU", "Surgery", "Pharmacology" },
                PasswordHash = "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new applicationUser
            {
                Id = 7,
                UserName = "student3",
                NormalizedUserName = "STUDENT3",
                Email = "student3@nurseiq.com",
                NormalizedEmail = "STUDENT3@NURSEIQ.COM",
                Fname = "مريم",
                Lname = "عبدالله",
                gender = gender.female,
                role = role.Student,
                Year_Level = YearLevel.Third_Year,
                BirthDate = new DateTime(2001, 7, 18),
                Educational_institution = "كلية التمريض - جامعة عين شمس",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string> { "Mental Health", "Community Health", "Research" },
                PasswordHash = "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new applicationUser
            {
                Id = 8,
                UserName = "student4",
                NormalizedUserName = "STUDENT4",
                Email = "student4@nurseiq.com",
                NormalizedEmail = "STUDENT4@NURSEIQ.COM",
                Fname = "يوسف",
                Lname = "إبراهيم",
                gender = gender.male,
                role = role.Student,
                Year_Level = YearLevel.Fourth_Year,
                BirthDate = new DateTime(2000, 4, 25),
                Educational_institution = "كلية التمريض - جامعة الإسكندرية",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string> { "Emergency", "Trauma", "Critical Care" },
                PasswordHash = "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()
            },
            // Excellence Student
            new applicationUser
            {
                Id = 9,
                UserName = "excellence1",
                NormalizedUserName = "EXCELLENCE1",
                Email = "excellence1@nurseiq.com",
                NormalizedEmail = "EXCELLENCE1@NURSEIQ.COM",
                Fname = "نور",
                Lname = "السيد",
                gender = gender.female,
                role = role.Excellence_student,
                Year_Level = YearLevel.Excellence_Year,
                BirthDate = new DateTime(1999, 9, 8),
                Educational_institution = "كلية التمريض - جامعة القاهرة",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string> { "Research", "Leadership", "Advanced Practice" },
                PasswordHash = "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()
            },
            // Graduate
            new applicationUser
            {
                Id = 10,
                UserName = "graduate1",
                NormalizedUserName = "GRADUATE1",
                Email = "graduate1@nurseiq.com",
                NormalizedEmail = "GRADUATE1@NURSEIQ.COM",
                Fname = "خالد",
                Lname = "محمد",
                gender = gender.male,
                role = role.graduate,
                Year_Level = YearLevel.Graduated,
                BirthDate = new DateTime(1998, 11, 14),
                Educational_institution = "كلية التمريض - جامعة عين شمس",
                Type_of_Educational_institution = Type_of_Edu_inst.college,
                interests_Fields = new List<string> { "Professional Development", "Specialization", "Teaching" },
                PasswordHash = "AQAAAAEAACcQAAAAEHQ36c3VJt2fP+m3v/6rF3hHENu2eYi5...",
                SecurityStamp = Guid.NewGuid().ToString()
            }
        };

            // ================= Courses =================
            public static readonly Course[] Courses = new[]
            {
            // First Year Courses
            new Course
            {
                Id = 1,
                Name = "أساسيات التمريض",
                Title = "مبادئ الرعاية التمريضية",
                YearLevel = CourseYearLevel.First_Year,
                courseType = CourseType.theoretical_Course,
                semister = CourseSemester.FirstSemester,
                Duration = "3 أشهر",
                imageUrl = "img/course1.jpg",
                smallDescription = "مقدمة في أساسيات التمريض",
                bigDescription = "دورة شاملة تغطي المبادئ الأساسية للتمريض والممارسة المهنية",
                courseTopics = new List<string> { "أخلاقيات التمريض", "سلامة المريض", "التواصل مع المريض", "الرعاية الأساسية" },
                coursePrerequisites = new List<string> { "شهادة الثانوية العامة" },
                UserId = 2
            },
            new Course
            {
                Id = 2,
                Name = "علم التشريح والفيزيولوجيا",
                Title = "دراسة جسم الإنسان",
                YearLevel = CourseYearLevel.First_Year,
                courseType = CourseType.theoretical_Course,
                semister = CourseSemester.FirstSemester,
                Duration = "4 أشهر",
                imageUrl = "img/course2.jpg",
                smallDescription = "دراسة تشريح ووظائف أعضاء الجسم",
                bigDescription = "دراسة مفصلة لتشريح ووظائف جميع أجهزة الجسم البشري",
                courseTopics = new List<string> { "الجهاز الهيكلي", "الجهاز العضلي", "الجهاز الدوري", "الجهاز التنفسي" },
                coursePrerequisites = new List<string> { "خلفية في علم الأحياء" },
                UserId = 2
            },
            new Course
            {
                Id = 3,
                Name = "المهارات التمريضية الأساسية",
                Title = "التطبيق العملي للتمريض",
                YearLevel = CourseYearLevel.First_Year,
                courseType = CourseType.practical_Course,
                semister = CourseSemester.SecondSemester,
                Duration = "3 أشهر",
                imageUrl = "img/course3.jpg",
                smallDescription = "تعلم المهارات العملية الأساسية",
                bigDescription = "تدريب عملي على المهارات التمريضية الأساسية في المختبر والمستشفى",
                courseTopics = new List<string> { "قياس العلامات الحيوية", "حقن الأدوية", "العناية بالجروح", "الرعاية الشخصية" },
                coursePrerequisites = new List<string> { "أساسيات التمريض" },
                UserId = 3
            },
            // Second Year Courses
            new Course
            {
                Id = 4,
                Name = "علم الأدوية",
                Title = "مقدمة في علم الأدوية",
                YearLevel = CourseYearLevel.Second_Year,
                courseType = CourseType.theoretical_Course,
                semister = CourseSemester.FirstSemester,
                Duration = "4 أشهر",
                imageUrl = "img/course4.jpg",
                smallDescription = "دراسة الأدوية وتأثيراتها",
                bigDescription = "دراسة شاملة للأدوية وتصنيفاتها وآليات عملها وتأثيراتها الجانبية",
                courseTopics = new List<string> { "المضادات الحيوية", "مسكنات الألم", "أدوية القلب", "أدوية الجهاز الهضمي" },
                coursePrerequisites = new List<string> { "علم التشريح والفيزيولوجيا" },
                UserId = 2
            },
            new Course
            {
                Id = 5,
                Name = "تمريض الباطنة",
                Title = "رعاية المرضى الداخليين",
                YearLevel = CourseYearLevel.Second_Year,
                courseType = CourseType.theoretical_Course,
                semister = CourseSemester.SecondSemester,
                Duration = "4 أشهر",
                imageUrl = "img/course5.jpg",
                smallDescription = "رعاية المرضى في الأقسام الداخلية",
                bigDescription = "دراسة شاملة لرعاية المرضى في الأقسام الداخلية المختلفة",
                courseTopics = new List<string> { "تمريض القلب", "تمريض الجهاز التنفسي", "تمريض الجهاز الهضمي", "تمريض الكلى" },
                coursePrerequisites = new List<string> { "علم الأدوية" },
                UserId = 3
            },
            // Third Year Courses
            new Course
            {
                Id = 6,
                Name = "تمريض الأطفال",
                Title = "رعاية الأطفال والرضع",
                YearLevel = CourseYearLevel.Third_Year,
                courseType = CourseType.theoretical_Course,
                semister = CourseSemester.FirstSemester,
                Duration = "4 أشهر",
                imageUrl = "img/course6.jpg",
                smallDescription = "رعاية خاصة بالأطفال",
                bigDescription = "دراسة متخصصة في رعاية الأطفال من الولادة حتى المراهقة",
                courseTopics = new List<string> { "رعاية حديثي الولادة", "تغذية الأطفال", "أمراض الأطفال الشائعة", "التطعيمات" },
                coursePrerequisites = new List<string> { "تمريض الباطنة" },
                UserId = 2
            },
            new Course
            {
                Id = 7,
                Name = "تمريض الجراحة",
                Title = "رعاية المرضى الجراحيين",
                YearLevel = CourseYearLevel.Third_Year,
                courseType = CourseType.practical_Course,
                semister = CourseSemester.SecondSemester,
                Duration = "4 أشهر",
                imageUrl = "img/course7.jpg",
                smallDescription = "رعاية ما قبل وبعد الجراحة",
                bigDescription = "تدريب عملي على رعاية المرضى قبل وأثناء وبعد العمليات الجراحية",
                courseTopics = new List<string> { "التحضير للجراحة", "رعاية ما بعد الجراحة", "العناية بالجروح الجراحية", "إدارة الألم" },
                coursePrerequisites = new List<string> { "المهارات التمريضية الأساسية" },
                UserId = 3
            },
            // Fourth Year Courses
            new Course
            {
                Id = 8,
                Name = "تمريض العناية المركزة",
                Title = "رعاية المرضى الحرجين",
                YearLevel = CourseYearLevel.Fourth_Year,
                courseType = CourseType.practical_Course,
                semister = CourseSemester.FirstSemester,
                Duration = "5 أشهر",
                imageUrl = "img/course8.jpg",
                smallDescription = "رعاية المرضى في العناية المركزة",
                bigDescription = "تدريب متقدم على رعاية المرضى الحرجين في وحدات العناية المركزة",
                courseTopics = new List<string> { "أجهزة التنفس الصناعي", "مراقبة العلامات الحيوية", "إدارة الأدوية الوريدية", "الإنعاش القلبي الرئوي" },
                coursePrerequisites = new List<string> { "تمريض الباطنة", "تمريض الجراحة" },
                UserId = 4
            },
            new Course
            {
                Id = 9,
                Name = "تمريض الطوارئ",
                Title = "رعاية حالات الطوارئ",
                YearLevel = CourseYearLevel.Fourth_Year,
                courseType = CourseType.practical_Course,
                semister = CourseSemester.SecondSemester,
                Duration = "4 أشهر",
                imageUrl = "img/course9.jpg",
                smallDescription = "رعاية حالات الطوارئ والإسعافات الأولية",
                bigDescription = "تدريب متخصص على التعامل مع حالات الطوارئ والإسعافات الأولية",
                courseTopics = new List<string> { "الإسعافات الأولية", "حالات الصدمة", "التسمم", "الحروق والكسور" },
                coursePrerequisites = new List<string> { "تمريض العناية المركزة" },
                UserId = 3
            },
            // Excellence Year Courses
            new Course
            {
                Id = 10,
                Name = "التمريض المتقدم",
                Title = "ممارسة التمريض المتقدمة",
                YearLevel = CourseYearLevel.Excellence_Year,
                courseType = CourseType.theoretical_Course,
                semister = CourseSemester.FirstSemester,
                Duration = "6 أشهر",
                imageUrl = "img/course10.jpg",
                smallDescription = "ممارسة التمريض على مستوى متقدم",
                bigDescription = "دراسة متقدمة في ممارسة التمريض والقيادة التمريضية",
                courseTopics = new List<string> { "القيادة التمريضية", "إدارة الجودة", "البحث التمريضي", "التطوير المهني" },
                coursePrerequisites = new List<string> { "جميع المواد السابقة" },
                UserId = 4
            }
        };

            // ================= Articles =================
            public static readonly Article[] Articles = new[]
            {
            new Article
            {
                Id = 1,
                Title = "التمريض في العناية المركزة: التحديات والحلول",
                Description = "مقال شامل عن تحديات التمريض في وحدات العناية المركزة وأفضل الممارسات",
                imageUrl = "img/article1.jpg",
                category = "العناية المركزة",
                authorImage = "img/doctor1.png",
                publishDate = "2025-01-15",
                readTime = "8 دقائق",
                Num_of_views = 1250,
                UserId = 2
            },
            new Article
            {
                Id = 2,
                Title = "أساسيات علم الأدوية للممرضين",
                Description = "دليل شامل لفهم آليات عمل الأدوية وتأثيراتها الجانبية",
                imageUrl = "img/article2.jpg",
                category = "علم الأدوية",
                authorImage = "img/doctor2.png",
                publishDate = "2025-01-12",
                readTime = "10 دقائق",
                Num_of_views = 980,
                UserId = 2
            },
            new Article
            {
                Id = 3,
                Title = "رعاية الأطفال في المستشفيات: دليل شامل",
                Description = "أفضل الممارسات في رعاية الأطفال والرضع في البيئة المستشفوية",
                imageUrl = "img/article3.jpg",
                category = "تمريض الأطفال",
                authorImage = "img/doctor3.png",
                publishDate = "2025-01-10",
                readTime = "12 دقيقة",
                Num_of_views = 750,
                UserId = 3
            },
            new Article
            {
                Id = 4,
                Title = "إدارة الألم في التمريض: الطرق الحديثة",
                Description = "استراتيجيات حديثة لإدارة الألم وتقييم مستوياته لدى المرضى",
                imageUrl = "img/article4.jpg",
                category = "إدارة الألم",
                authorImage = "img/doctor1.png",
                publishDate = "2025-01-08",
                readTime = "9 دقائق",
                Num_of_views = 1100,
                UserId = 2
            },
            new Article
            {
                Id = 5,
                Title = "التمريض النفسي: رعاية الصحة العقلية",
                Description = "دور الممرض في رعاية المرضى النفسيين وتقديم الدعم النفسي",
                imageUrl = "img/article5.jpg",
                category = "التمريض النفسي",
                authorImage = "img/doctor4.png",
                publishDate = "2025-01-05",
                readTime = "11 دقيقة",
                Num_of_views = 650,
                UserId = 4
            },
            new Article
            {
                Id = 6,
                Title = "الإنعاش القلبي الرئوي: البروتوكولات الحديثة",
                Description = "أحدث البروتوكولات والإرشادات للإنعاش القلبي الرئوي",
                imageUrl = "img/article6.jpg",
                category = "الطوارئ",
                authorImage = "img/doctor3.png",
                publishDate = "2025-01-03",
                readTime = "7 دقائق",
                Num_of_views = 1400,
                UserId = 3
            },
            new Article
            {
                Id = 7,
                Title = "العدوى المكتسبة من المستشفيات: الوقاية والسيطرة",
                Description = "استراتيجيات الوقاية من العدوى المكتسبة من المستشفيات",
                imageUrl = "img/article7.jpg",
                category = "مكافحة العدوى",
                authorImage = "img/doctor2.png",
                publishDate = "2025-01-01",
                readTime = "13 دقيقة",
                Num_of_views = 890,
                UserId = 2
            },
            new Article
            {
                Id = 8,
                Title = "التمريض في الجراحة: قبل وأثناء وبعد العملية",
                Description = "دور الممرض في جميع مراحل العملية الجراحية",
                imageUrl = "img/article8.jpg",
                category = "تمريض الجراحة",
                authorImage = "img/doctor3.png",
                publishDate = "2024-12-28",
                readTime = "10 دقائق",
                Num_of_views = 720,
                UserId = 3
            }
        };

            // ================= Announcements =================
            public static readonly Announcement[] Announcements = new[]
            {
            new Announcement
            {
                Id = 1,
                Title = "مرحباً بكم في منصة NursingIQ",
                Content = "نرحب بكم في منصة التمريض الرائدة في مصر. نقدم لكم أفضل المحتوى التعليمي والتدريبي في مجال التمريض",
                Date = new DateTime(2025, 1, 15),
                category = "عام",
                AdminImageUrl = "img/admin.png",
                CreatedByAdminId = 1
            },
            new Announcement
            {
                Id = 2,
                Title = "إطلاق دورات جديدة في التمريض",
                Content = "يسرنا أن نعلن عن إطلاق مجموعة جديدة من الدورات التدريبية المتخصصة في التمريض",
                Date = new DateTime(2025, 1, 12),
                category = "تحديث",
                AdminImageUrl = "img/admin.png",
                CreatedByAdminId = 1
            },
            new Announcement
            {
                Id = 3,
                Title = "ورشة عمل حول التمريض في العناية المركزة",
                Content = "ورشة عمل مجانية حول أفضل الممارسات في التمريض في وحدات العناية المركزة - 25 يناير 2025",
                Date = new DateTime(2025, 1, 10),
                category = "فعاليات",
                AdminImageUrl = "img/admin.png",
                CreatedByAdminId = 1
            },
            new Announcement
            {
                Id = 4,
                Title = "مسابقة أفضل مقال تمريضي",
                Content = "مسابقة شهرية لأفضل مقال في التمريض مع جوائز قيمة للفائزين",
                Date = new DateTime(2025, 1, 8),
                category = "مسابقات",
                AdminImageUrl = "img/admin.png",
                CreatedByAdminId = 1
            },
            new Announcement
            {
                Id = 5,
                Title = "تحديث نظام الاختبارات",
                Content = "تم تحديث نظام الاختبارات ليشمل المزيد من الأسئلة التفاعلية والتقييم الذكي",
                Date = new DateTime(2025, 1, 5),
                category = "تحديث",
                AdminImageUrl = "img/admin.png",
                CreatedByAdminId = 1
            },
            new Announcement
            {
                Id = 6,
                Title = "دورة تدريبية في الإسعافات الأولية",
                Content = "دورة تدريبية شاملة في الإسعافات الأولية مع شهادة معتمدة - التسجيل مفتوح الآن",
                Date = new DateTime(2025, 1, 3),
                category = "دورات",
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
                FullName = "محمد علي",
                phone = "01012345678",
                email = "mohamed@example.com",
                InquiryType = InquiryType.TechnicalProblem,
                message = "أريد معرفة المزيد عن منصة NursingIQ والخدمات المتاحة",
                CreatedByAdminId = 1
            },
            new ContactForm
            {
                ID = 2,
                FullName = "سارة أحمد",
                phone = "01098765432",
                email = "sara@example.com",
                InquiryType = InquiryType.PaymentProblem,
                message = "لدي مشكلة في تسجيل الدخول إلى حسابي",
                CreatedByAdminId = 1
            },
            new ContactForm
            {
                ID = 3,
                FullName = "أحمد محمود",
                phone = "01123456789",
                email = "ahmed@example.com",
                InquiryType = InquiryType.InquiryAboutCourse,
                message = "أريد الاستفسار عن دورة تمريض العناية المركزة ومتطلبات التسجيل",
                CreatedByAdminId = 1
            },
            new ContactForm
            {
                ID = 4,
                FullName = "فاطمة حسن",
                phone = "01234567890",
                email = "fatma@example.com",
                InquiryType = InquiryType.CertificateInquiry,
                message = "متى يمكنني الحصول على شهادة إتمام الدورة التدريبية؟",
                CreatedByAdminId = 1
            },
            new ContactForm
            {
                ID = 5,
                FullName = "علي إبراهيم",
                phone = "01345678901",
                email = "ali@example.com",
                InquiryType = InquiryType.Other,
                message = "هل يمكنني الحصول على نسخة من المحاضرات المسجلة؟",
                CreatedByAdminId = 1
            },
            new ContactForm
            {
                ID = 6,
                FullName = "مريم عبدالله",
                phone = "01456789012",
                email = "mariam@example.com",
                InquiryType = InquiryType.TechnicalProblem,
                message = "لا يمكنني تحميل المواد التعليمية من الموقع",
                CreatedByAdminId = 1
            }
        };

            // ================= Diplomas =================
            public static readonly Diploma[] Diplomas = new[]
            {
            new Diploma
            {
                ID = 1,
                Title = "دبلوم تمريض العناية المركزة",
                Description = "تدريب متخصص للممرضين في وحدات العناية المركزة مع شهادة معتمدة",
                Duration = "6 أشهر",
                requirement = new List<string> { "شهادة التمريض", "سنتان خبرة في التمريض", "اجتياز المقابلة الشخصية" },
                register_steps = new List<string> { "التسجيل عبر الإنترنت", "تقديم المستندات المطلوبة", "دفع الرسوم", "اجتياز المقابلة" },
                CreatedByAdminId = 1
            },
            new Diploma
            {
                ID = 2,
                Title = "دبلوم تمريض الأطفال",
                Description = "تخصص في رعاية الأطفال والرضع مع التركيز على الحالات الحرجة",
                Duration = "4 أشهر",
                requirement = new List<string> { "شهادة التمريض", "خبرة في رعاية الأطفال" },
                register_steps = new List<string> { "التسجيل عبر الإنترنت", "تقديم المستندات", "اجتياز المقابلة الشخصية" },
                CreatedByAdminId = 1
            },
            new Diploma
            {
                ID = 3,
                Title = "دبلوم التمريض النفسي",
                Description = "تخصص في رعاية المرضى النفسيين وتقديم الدعم النفسي",
                Duration = "5 أشهر",
                requirement = new List<string> { "شهادة التمريض", "خبرة في التمريض العام", "اجتياز اختبار القبول" },
                register_steps = new List<string> { "التسجيل عبر الإنترنت", "تقديم المستندات", "اجتياز اختبار القبول", "دفع الرسوم" },
                CreatedByAdminId = 1
            },
            new Diploma
            {
                ID = 4,
                Title = "دبلوم تمريض الطوارئ",
                Description = "تخصص في التعامل مع حالات الطوارئ والإسعافات الأولية",
                Duration = "4 أشهر",
                requirement = new List<string> { "شهادة التمريض", "خبرة في التمريض العام" },
                register_steps = new List<string> { "التسجيل عبر الإنترنت", "تقديم المستندات", "اجتياز المقابلة" },
                CreatedByAdminId = 1
            },
            new Diploma
            {
                ID = 5,
                Title = "دبلوم إدارة التمريض",
                Description = "تخصص في إدارة الفرق التمريضية وإدارة الجودة في التمريض",
                Duration = "6 أشهر",
                requirement = new List<string> { "شهادة التمريض", "3 سنوات خبرة", "خبرة في الإدارة" },
                register_steps = new List<string> { "التسجيل عبر الإنترنت", "تقديم المستندات", "اجتياز المقابلة الشخصية", "دفع الرسوم" },
                CreatedByAdminId = 1
            }
        };

            public static readonly DiplomaFeature[] DiplomaFeatures = new[]
            {
            // ICU Diploma Features
            new DiplomaFeature
            {
                Id = 1,
                Title = "تدريب عملي في العناية المركزة",
                Description = "تدريب عملي مباشر في وحدات العناية المركزة مع المرضى الحقيقيين",
                Icon = "icon-icu.png",
                DiplomaId = 1
            },
            new DiplomaFeature
            {
                Id = 2,
                Title = "مدربون معتمدون",
                Description = "جميع الدورات تدرس من قبل أطباء وممرضين معتمدين",
                Icon = "icon-doctor.png",
                DiplomaId = 1
            },
            new DiplomaFeature
            {
                Id = 3,
                Title = "شهادة معتمدة",
                Description = "شهادة معتمدة من وزارة الصحة معترف بها في جميع المستشفيات",
                Icon = "icon-certificate.png",
                DiplomaId = 1
            },
            // Pediatric Diploma Features
            new DiplomaFeature
            {
                Id = 4,
                Title = "تركيز على رعاية الأطفال",
                Description = "محتوى متخصص في رعاية الأطفال والرضع",
                Icon = "icon-child.png",
                DiplomaId = 2
            },
            new DiplomaFeature
            {
                Id = 5,
                Title = "تدريب في مستشفيات الأطفال",
                Description = "تدريب عملي في مستشفيات الأطفال المتخصصة",
                Icon = "icon-hospital.png",
                DiplomaId = 2
            },
            new DiplomaFeature
            {
                Id = 6,
                Title = "متابعة مستمرة",
                Description = "متابعة مستمرة بعد التخرج ودعم مهني",
                Icon = "icon-support.png",
                DiplomaId = 2
            },
            // Mental Health Diploma Features
            new DiplomaFeature
            {
                Id = 7,
                Title = "تدريب في الصحة النفسية",
                Description = "تدريب متخصص في رعاية المرضى النفسيين",
                Icon = "icon-mental-health.png",
                DiplomaId = 3
            },
            new DiplomaFeature
            {
                Id = 8,
                Title = "تقنيات العلاج النفسي",
                Description = "تعلم تقنيات العلاج النفسي والاستشارة",
                Icon = "icon-therapy.png",
                DiplomaId = 3
            },
            // Emergency Diploma Features
            new DiplomaFeature
            {
                Id = 9,
                Title = "الإسعافات الأولية المتقدمة",
                Description = "تدريب على الإسعافات الأولية المتقدمة",
                Icon = "icon-emergency.png",
                DiplomaId = 4
            },
            new DiplomaFeature
            {
                Id = 10,
                Title = "التعامل مع الحالات الحرجة",
                Description = "تدريب على التعامل مع الحالات الحرجة والطوارئ",
                Icon = "icon-critical.png",
                DiplomaId = 4
            },
            // Management Diploma Features
            new DiplomaFeature
            {
                Id = 11,
                Title = "إدارة الفرق التمريضية",
                Description = "تعلم إدارة الفرق التمريضية وتنظيم العمل",
                Icon = "icon-management.png",
                DiplomaId = 5
            },
            new DiplomaFeature
            {
                Id = 12,
                Title = "إدارة الجودة",
                Description = "تعلم معايير الجودة في التمريض وإدارة الجودة",
                Icon = "icon-quality.png",
                DiplomaId = 5
            }
        };

            // ================= Forum Topics =================
            public static readonly Forumtopic[] Forumtopics = new[]
            {
            new Forumtopic
            {
                Id = 1,
                Title = "كيفية دراسة التمريض بفعالية؟",
                Description = "شاركوا نصائحكم في دراسة التمريض وأفضل الطرق للاستذكار",
                category = "الدراسة",
                comments = new List<string> { "استخدم البطاقات التعليمية", "الدراسة الجماعية مفيدة جداً", "راجع المحاضرات يومياً" },
                num_of_likes = 25,
                num_of_views = 450,
                UserId = 5
            },
            new Forumtopic
            {
                Id = 2,
                Title = "أفضل المصادر لدراسة علم الأدوية",
                Description = "ناقش أفضل الكتب والملاحظات لدراسة علم الأدوية",
                category = "علم الأدوية",
                comments = new List<string> { "كتاب كاتزونج في علم الأدوية", "الملاحظات المحلية مفيدة", "استخدم التطبيقات التعليمية" },
                num_of_likes = 18,
                num_of_views = 320,
                UserId = 6
            },
            new Forumtopic
            {
                Id = 3,
                Title = "تجاربكم في التدريب العملي",
                Description = "شاركوا تجاربكم في التدريب العملي في المستشفيات",
                category = "التدريب العملي",
                comments = new List<string> { "التدريب في العناية المركزة كان صعباً لكن مفيداً", "تعلمت الكثير من الممرضين ذوي الخبرة" },
                num_of_likes = 32,
                num_of_views = 580,
                UserId = 7
            },
            new Forumtopic
            {
                Id = 4,
                Title = "نصائح للتعامل مع المرضى الصعبيين",
                Description = "كيف تتعاملون مع المرضى الصعبيين أو العدوانيين؟",
                category = "الممارسة المهنية",
                comments = new List<string> { "الصبر والتفهم مفتاح النجاح", "استخدم تقنيات التواصل الفعال", "اطلب المساعدة من الفريق" },
                num_of_likes = 28,
                num_of_views = 420,
                UserId = 8
            },
            new Forumtopic
            {
                Id = 5,
                Title = "أفضل التطبيقات للممرضين",
                Description = "ما هي أفضل التطبيقات التي تساعدكم في العمل؟",
                category = "التكنولوجيا",
                comments = new List<string> { "تطبيق حساب الجرعات مفيد جداً", "تطبيق مراقبة العلامات الحيوية", "تطبيق الأدوية والتفاعلات" },
                num_of_likes = 15,
                num_of_views = 280,
                UserId = 9
            },
            new Forumtopic
            {
                Id = 6,
                Title = "كيفية إدارة الوقت في التمريض",
                Description = "نصائح لإدارة الوقت بكفاءة أثناء العمل في التمريض",
                category = "إدارة الوقت",
                comments = new List<string> { "خطط مهامك مسبقاً", "استخدم قوائم المهام", "تعلم أن تقول لا عند الحاجة" },
                num_of_likes = 22,
                num_of_views = 350,
                UserId = 10
            }
        };

            // ================= Medical Terms =================
            public static readonly MedicalTerm[] MedicalTerms = new[]
            {
            // Anatomy Terms
                       new MedicalTerm
            {
                Id = 1,
                arabicName = "قلب",
                englishName = "Heart",
                latinName = "Cor",
                category = "التشريح",
                example = "القلب يضخ الدم إلى جميع أنحاء الجسم",
                synonyms = new List<string> { "قلبي", "قلبي وعائي" },
                UserId = 2
            },
            new MedicalTerm
            {
                Id = 2,
                arabicName = "رئة",
                englishName = "Lung",
                latinName = "Pulmo",
                category = "التشريح",
                example = "الرئة تساعد في التنفس وتبادل الغازات",
                synonyms = new List<string> { "رئوي", "تنفسي" },
                UserId = 2
            },
            new MedicalTerm
            {
                Id = 3,
                arabicName = "كبد",
                englishName = "Liver",
                latinName = "Hepar",
                category = "التشريح",
                example = "الكبد يقوم بتصفية الدم وإنتاج الصفراء",
                synonyms = new List<string> { "كبدي", "هيباتيك" },
                UserId = 2
            },
            new MedicalTerm
            {
                Id = 4,
                arabicName = "كلية",
                englishName = "Kidney",
                latinName = "Ren",
                category = "التشريح",
                example = "الكلى تقوم بتصفية الدم وإنتاج البول",
                synonyms = new List<string> { "كلوي", "رينال" },
                UserId = 3
            },
            // Symptoms Terms
            new MedicalTerm
            {
                Id = 5,
                arabicName = "حمى",
                englishName = "Fever",
                latinName = "Febris",
                category = "الأعراض",
                example = "الحمى هي ارتفاع في درجة حرارة الجسم",
                synonyms = new List<string> { "ارتفاع الحرارة", "سخونة" },
                UserId = 2
            },
            new MedicalTerm
            {
                Id = 6,
                arabicName = "صداع",
                englishName = "Headache",
                latinName = "Cephalgia",
                category = "الأعراض",
                example = "الصداع هو ألم في الرأس أو الرقبة",
                synonyms = new List<string> { "ألم الرأس", "وجع الرأس" },
                UserId = 3
            },
            new MedicalTerm
            {
                Id = 7,
                arabicName = "غثيان",
                englishName = "Nausea",
                latinName = "Nausea",
                category = "الأعراض",
                example = "الغثيان هو الشعور بالرغبة في التقيؤ",
                synonyms = new List<string> { "رغبة في التقيؤ", "دوخة" },
                UserId = 2
            },
            // Procedures Terms
            new MedicalTerm
            {
                Id = 8,
                arabicName = "جراحة",
                englishName = "Surgery",
                latinName = "Chirurgia",
                category = "الإجراءات",
                example = "الجراحة هي إجراء طبي يتطلب قطع الأنسجة",
                synonyms = new List<string> { "عملية جراحية", "تدخل جراحي" },
                UserId = 3
            },
            new MedicalTerm
            {
                Id = 9,
                arabicName = "تنفس صناعي",
                englishName = "Artificial Respiration",
                latinName = "Respiratio Artificialis",
                category = "الإجراءات",
                example = "التنفس الصناعي هو مساعدة المريض على التنفس",
                synonyms = new List<string> { "تهوية صناعية", "دعم تنفسي" },
                UserId = 4
            },
            // Medications Terms
            new MedicalTerm
            {
                Id = 10,
                arabicName = "مضاد حيوي",
                englishName = "Antibiotic",
                latinName = "Antibioticum",
                category = "الأدوية",
                example = "المضاد الحيوي يقتل البكتيريا أو يمنع نموها",
                synonyms = new List<string> { "مضاد بكتيري", "مضاد جرثومي" },
                UserId = 2
            },
            new MedicalTerm
            {
                Id = 11,
                arabicName = "مسكن ألم",
                englishName = "Analgesic",
                latinName = "Analgeticum",
                category = "الأدوية",
                example = "مسكن الألم يخفف من الشعور بالألم",
                synonyms = new List<string> { "مخدر", "مهدئ" },
                UserId = 3
            }
        };

            // ================= Medicines =================
            public static readonly Medicine[] Medicines = new[]
            {
            // Analgesics
            new Medicine
            {
                Id = 1,
                arabicName = "باراسيتامول",
                englishName = "Paracetamol",
                latinName = "Acetaminophen",
                category = "مسكنات الألم",
                form = "أقراص",
                description = "مسكن للألم وخافض للحرارة",
                indications = "الحمى، الصداع، آلام الجسم",
                sideEffects = "غثيان، طفح جلدي، تلف الكبد (بجرعات عالية)",
                dosage = "500-1000 مجم كل 6-8 ساعات",
                UserId = 2
            },
            new Medicine
            {
                Id = 2,
                arabicName = "إيبوبروفين",
                englishName = "Ibuprofen",
                latinName = "Ibuprofenum",
                category = "مسكنات الألم",
                form = "أقراص",
                description = "مسكن للألم ومضاد للالتهاب",
                indications = "آلام المفاصل، الصداع، الحمى",
                sideEffects = "اضطراب المعدة، نزيف معوي، مشاكل في الكلى",
                dosage = "200-400 مجم كل 6-8 ساعات",
                UserId = 2
            },
            // Antibiotics
            new Medicine
            {
                Id = 3,
                arabicName = "أموكسيسيلين",
                englishName = "Amoxicillin",
                latinName = "Amoxicillinum",
                category = "مضادات حيوية",
                form = "كبسولات",
                description = "مضاد حيوي واسع الطيف",
                indications = "التهابات الجهاز التنفسي، التهابات المسالك البولية",
                sideEffects = "إسهال، طفح جلدي، حساسية",
                dosage = "250-500 مجم كل 8 ساعات",
                UserId = 2
            },
            new Medicine
            {
                Id = 4,
                arabicName = "أزيثروميسين",
                englishName = "Azithromycin",
                latinName = "Azithromycinum",
                category = "مضادات حيوية",
                form = "أقراص",
                description = "مضاد حيوي من مجموعة الماكروليد",
                indications = "التهابات الجهاز التنفسي، التهابات الجلد",
                sideEffects = "غثيان، إسهال، اضطراب في المعدة",
                dosage = "500 مجم مرة واحدة يومياً لمدة 3 أيام",
                UserId = 3
            },
            // Cardiovascular
            new Medicine
            {
                Id = 5,
                arabicName = "أتينولول",
                englishName = "Atenolol",
                latinName = "Atenololum",
                category = "أدوية القلب",
                form = "أقراص",
                description = "حاصرات بيتا لعلاج ارتفاع ضغط الدم",
                indications = "ارتفاع ضغط الدم، عدم انتظام ضربات القلب",
                sideEffects = "بطء القلب، انخفاض ضغط الدم، تعب",
                dosage = "25-100 مجم مرة واحدة يومياً",
                UserId = 3
            },
            new Medicine
            {
                Id = 6,
                arabicName = "أملوديبين",
                englishName = "Amlodipine",
                latinName = "Amlodipinum",
                category = "أدوية القلب",
                form = "أقراص",
                description = "حاصرات قنوات الكالسيوم",
                indications = "ارتفاع ضغط الدم، الذبحة الصدرية",
                sideEffects = "تورم الكاحلين، صداع، دوخة",
                dosage = "5-10 مجم مرة واحدة يومياً",
                UserId = 4
            },
            // Gastrointestinal
            new Medicine
            {
                Id = 7,
                arabicName = "أوميبرازول",
                englishName = "Omeprazole",
                latinName = "Omeprazolum",
                category = "أدوية الجهاز الهضمي",
                form = "كبسولات",
                description = "مثبط مضخة البروتون",
                indications = "قرحة المعدة، ارتجاع المريء",
                sideEffects = "صداع، غثيان، إسهال",
                dosage = "20-40 مجم مرة واحدة يومياً",
                UserId = 2
            },
            new Medicine
            {
                Id = 8,
                arabicName = "دومبيريدون",
                englishName = "Domperidone",
                latinName = "Domperidonum",
                category = "أدوية الجهاز الهضمي",
                form = "أقراص",
                description = "مضاد للغثيان والقيء",
                indications = "الغثيان، القيء، عسر الهضم",
                sideEffects = "جفاف الفم، صداع، اضطراب في المعدة",
                dosage = "10 مجم 3 مرات يومياً",
                UserId = 3
            },
            // Respiratory
            new Medicine
            {
                Id = 9,
                arabicName = "سالبوتامول",
                englishName = "Salbutamol",
                latinName = "Salbutamolum",
                category = "أدوية الجهاز التنفسي",
                form = "بخاخ",
                description = "موسع للشعب الهوائية",
                indications = "الربو، التهاب الشعب الهوائية",
                sideEffects = "رعشة، تسارع ضربات القلب، صداع",
                dosage = "1-2 بخة حسب الحاجة",
                UserId = 4
            },
            new Medicine
            {
                Id = 10,
                arabicName = "بريدنيزولون",
                englishName = "Prednisolone",
                latinName = "Prednisolonum",
                category = "أدوية الجهاز التنفسي",
                form = "أقراص",
                description = "كورتيكوستيرويد مضاد للالتهاب",
                indications = "الربو الحاد، التهاب المفاصل",
                sideEffects = "زيادة الوزن، ارتفاع ضغط الدم، هشاشة العظام",
                dosage = "5-60 مجم يومياً حسب الحالة",
                UserId = 2
            }
        };

            // ================= Offers =================
            public static readonly Offer[] Offers = new[]
            {
            // Training Offers
                        new Offer
            {
                Id = 1,
                Title = "عرض تدريب العناية المركزة",
                SubTitle = "وفر 20%",
                category = "Training",
                Description = "خصم خاص على دبلوم العناية المركزة مع تدريب عملي متقدم",
                OriginalPrice = 1000,
                DiscountPercentage = 20,
                imageUrl = "img/offer1.png",
                expiredAt = new DateTime(2025, 9, 5),
                features = new List<string> { "جلسات عملية", "مدربون معتمدون", "شهادة معتمدة" },
                CreatedByAdminId = 1
            },
            new Offer
            {
                Id = 2,
                Title = "عرض دورة علم الأدوية",
                SubTitle = "وفر 10%",
                category = "Course",
                Description = "خصم على دورة علم الأدوية مع مواد إضافية مجانية",
                OriginalPrice = 500,
                DiscountPercentage = 10,
                imageUrl = "img/offer2.png",
                expiredAt = new DateTime(2025, 7, 1),
                features = new List<string> { "مواد مجانية", "تمارين إضافية", "دعم أكاديمي" },
                CreatedByAdminId = 1
            },
            new Offer
            {
                Id = 3,
                Title = "عرض تدريب الطوارئ",
                SubTitle = "وفر 25%",
                category = "Training",
                Description = "خصم كبير على برنامج تدريب الطوارئ الطبية",
                OriginalPrice = 800,
                DiscountPercentage = 25,
                imageUrl = "img/offer3.png",
                expiredAt = new DateTime(2025, 8, 15),
                features = new List<string> { "محاكاة حالات طوارئ", "تدريب على المعدات", "شهادة دولية" },
                CreatedByAdminId = 2
            },
            // Course Offers
            new Offer
            {
                Id = 4,
                Title = "عرض دورات التمريض المتقدم",
                SubTitle = "وفر 30%",
                category = "Course",
                Description = "خصم خاص على جميع دورات التمريض المتقدم",
                OriginalPrice = 1200,
                DiscountPercentage = 30,
                imageUrl = "img/offer4.png",
                expiredAt = new DateTime(2025, 6, 30),
                features = new List<string> { "دورات متخصصة", "متابعة شخصية", "شهادات معتمدة" },
                CreatedByAdminId = 1
            },
            new Offer
            {
                Id = 5,
                Title = "عرض الطلاب الجدد",
                SubTitle = "وفر 40%",
                category = "Course",
                Description = "ترحيب خاص بالطلاب الجدد - خصم كبير على أول دورة",
                OriginalPrice = 600,
                DiscountPercentage = 40,
                imageUrl = "img/offer5.png",
                expiredAt = new DateTime(2025, 5, 20),
                features = new List<string> { "خصم إضافي", "مواد مجانية", "دعم أكاديمي" },
                CreatedByAdminId = 1
            },
            // Diploma Offers
            new Offer
            {
                Id = 6,
                Title = "عرض الدبلومات المهنية",
                SubTitle = "وفر 35%",
                category = "Diploma",
                Description = "خصم خاص على جميع الدبلومات المهنية في التمريض",
                OriginalPrice = 2000,
                DiscountPercentage = 35,
                imageUrl = "img/offer6.png",
                expiredAt = new DateTime(2025, 10, 1),
                features = new List<string> { "دبلومات معتمدة", "تدريب عملي", "فرص عمل" },
                CreatedByAdminId = 2
            },
            new Offer
            {
                Id = 7,
                Title = "عرض نهاية العام",
                SubTitle = "وفر 50%",
                category = "All",
                Description = "عرض نهاية العام - خصم كبير على جميع الخدمات",
                OriginalPrice = 1500,
                DiscountPercentage = 50,
                imageUrl = "img/offer7.png",
                expiredAt = new DateTime(2025, 12, 31),
                features = new List<string> { "خصم شامل", "جميع الخدمات", "عرض محدود" },
                CreatedByAdminId = 1
            },
            // Expired Offer
            new Offer
            {
                Id = 8,
                Title = "عرض منتهي الصلاحية",
                SubTitle = "انتهى العرض",
                category = "Course",
                Description = "هذا العرض منتهي الصلاحية",
                OriginalPrice = 1000,
                DiscountPercentage = 50,
                imageUrl = "img/offer8.png",
                expiredAt = new DateTime(2024, 12, 31),
                features = new List<string> { "عرض منتهي" },
                CreatedByAdminId = 1
            }
        };

            // ================= Trainings =================
            public static readonly Training[] Trainings = new[]
            {
            // ICU Training
           new Training
            {
                Id = 1,
                Title = "تدريب العناية المركزة",
                HospitalName = "مستشفى القاهرة الدولي",
                Location = "القاهرة",
                Category = "تدريب عملي",
                salary = 5000,
                Experience = "سنتان",
                requirement = new List<string> { "خبرة في العناية المركزة", "شهادة تمريض", "شهادة BLS" },
                Description = "برنامج تدريبي متقدم في العناية المركزة مع تدريب عملي على أحدث المعدات",
                imageUrl = "img/training1.png",
                postedDate = new DateTime(2025, 9, 13),
                deadline = new DateTime(2025, 9, 13),
                CreatedByAdminId = 1
            },
            // Pediatrics Training
            new Training
            {
                Id = 2,
                Title = "تدريب طب الأطفال",
                HospitalName = "مستشفى الأطفال",
                Location = "الجيزة",
                Category = "Pediatrics",
                salary = 4000,
                Experience = "سنة واحدة",
                requirement = new List<string> { "خبرة في طب الأطفال", "شهادة تمريض" },
                Description = "تدريب متخصص في رعاية الأطفال المرضى مع التركيز على التواصل مع الأطفال",
                imageUrl = "img/training2.png",
                postedDate = new DateTime(2025, 9, 13),
                deadline = new DateTime(2025, 9, 20),
                CreatedByAdminId = 1
            },
            // Emergency Training
            new Training
            {
                Id = 3,
                Title = "تدريب الطوارئ الطبية",
                HospitalName = "مستشفى الطوارئ",
                Location = "الإسكندرية",
                Category = "Emergency",
                salary = 4500,
                Experience = "سنة ونصف",
                requirement = new List<string> { "خبرة في الطوارئ", "شهادة ACLS", "سرعة في الاستجابة" },
                Description = "تدريب متقدم في التعامل مع حالات الطوارئ الطبية والحوادث",
                imageUrl = "img/training3.png",
                postedDate = new DateTime(2025, 8, 15),
                deadline = new DateTime(2025, 8, 30),
                CreatedByAdminId = 2
            },
            // Surgery Training
            new Training
            {
                Id = 4,
                Title = "تدريب التمريض الجراحي",
                HospitalName = "مستشفى الجراحة المتخصصة",
                Location = "القاهرة",
                Category = "Surgery",
                salary = 5500,
                Experience = "سنتان",
                requirement = new List<string> { "خبرة في الجراحة", "دقة في العمل", "تحمل ضغط العمل" },
                Description = "تدريب متخصص في التمريض الجراحي مع التركيز على التعقيم والسلامة",
                imageUrl = "img/training4.png",
                postedDate = new DateTime(2025, 7, 20),
                deadline = new DateTime(2025, 8, 5),
                CreatedByAdminId = 1
            },
            // Oncology Training
            new Training
            {
                Id = 5,
                Title = "تدريب أورام الأطفال",
                HospitalName = "مستشفى سرطان الأطفال",
                Location = "الجيزة",
                Category = "Oncology",
                salary = 4800,
                Experience = "سنة ونصف",
                requirement = new List<string> { "خبرة في الأورام", "تعاطف مع المرضى", "شهادة تمريض" },
                Description = "تدريب متخصص في رعاية الأطفال المصابين بالسرطان مع الدعم النفسي",
                imageUrl = "img/training5.png",
                postedDate = new DateTime(2025, 6, 10),
                deadline = new DateTime(2025, 6, 25),
                CreatedByAdminId = 2
            },
            // Cardiology Training
            new Training
            {
                Id = 6,
                Title = "تدريب القلب والأوعية الدموية",
                HospitalName = "معهد القلب",
                Location = "القاهرة",
                Category = "Cardiology",
                salary = 5200,
                Experience = "سنتان",
                requirement = new List<string> { "خبرة في القلب", "شهادة ACLS", "دقة في المراقبة" },
                Description = "تدريب متقدم في رعاية مرضى القلب مع استخدام أحدث التقنيات",
                imageUrl = "img/training6.png",
                postedDate = new DateTime(2025, 5, 15),
                deadline = new DateTime(2025, 5, 30),
                CreatedByAdminId = 1
            },
            // Neonatal Training
            new Training
            {
                Id = 7,
                Title = "تدريب العناية بالأطفال حديثي الولادة",
                HospitalName = "مستشفى الولادة",
                Location = "الإسكندرية",
                Category = "Neonatal",
                salary = 4600,
                Experience = "سنة واحدة",
                requirement = new List<string> { "خبرة في حديثي الولادة", "صبر ودقة", "شهادة NRP" },
                Description = "تدريب متخصص في رعاية الأطفال حديثي الولادة والخدج",
                imageUrl = "img/training7.png",
                postedDate = new DateTime(2025, 4, 20),
                deadline = new DateTime(2025, 5, 5),
                CreatedByAdminId = 2
            },
            // Mental Health Training
            new Training
            {
                Id = 8,
                Title = "تدريب الصحة النفسية",
                HospitalName = "مستشفى الطب النفسي",
                Location = "القاهرة",
                Category = "Mental Health",
                salary = 4200,
                Experience = "سنة واحدة",
                requirement = new List<string> { "خبرة في الصحة النفسية", "تعاطف", "مهارات تواصل" },
                Description = "تدريب في رعاية المرضى النفسيين مع التركيز على الدعم النفسي",
                imageUrl = "img/training8.png",
                postedDate = new DateTime(2025, 3, 10),
                deadline = new DateTime(2025, 3, 25),
                CreatedByAdminId = 1
            }
        };

            public static readonly UserRegisteredTraining[] UserRegisteredTrainings = new[]
            {
            // Student registrations
            new UserRegisteredTraining { UserId = 2, TrainingId = 1 }, // أحمد محمد - ICU Training
            new UserRegisteredTraining { UserId = 2, TrainingId = 2 }, // أحمد محمد - Pediatrics Training
            new UserRegisteredTraining { UserId = 3, TrainingId = 3 }, // فاطمة أحمد - Emergency Training
            new UserRegisteredTraining { UserId = 3, TrainingId = 4 }, // فاطمة أحمد - Surgery Training
            new UserRegisteredTraining { UserId = 4, TrainingId = 5 }, // محمد علي - Oncology Training
            new UserRegisteredTraining { UserId = 4, TrainingId = 6 }, // محمد علي - Cardiology Training
            new UserRegisteredTraining { UserId = 5, TrainingId = 7 }, // نور الدين - Neonatal Training
            new UserRegisteredTraining { UserId = 5, TrainingId = 8 }, // نور الدين - Mental Health Training
            
            // Doctor registrations
            new UserRegisteredTraining { UserId = 6, TrainingId = 1 }, // د. سارة محمود - ICU Training
            new UserRegisteredTraining { UserId = 7, TrainingId = 2 }, // د. خالد حسن - Pediatrics Training
            new UserRegisteredTraining { UserId = 8, TrainingId = 3 }, // د. مريم عبدالله - Emergency Training
            new UserRegisteredTraining { UserId = 9, TrainingId = 4 }, // د. يوسف إبراهيم - Surgery Training
            new UserRegisteredTraining { UserId = 10, TrainingId = 5 }, // د. رانيا محمد - Oncology Training
            new UserRegisteredTraining { UserId = 6, TrainingId = 6 }, // د. سارة محمود - Cardiology Training
            
            // Graduate registrations
            new UserRegisteredTraining { UserId = 11, TrainingId = 7 }, // علي أحمد - Neonatal Training
            new UserRegisteredTraining { UserId = 11, TrainingId = 8 }, // علي أحمد - Mental Health Training
        };

            // ================= Training Videos =================
            public static readonly training_video[] TrainingVideos = new[]
            {
            // Practical Skills Videos
            new training_video
            {
                Id = 1,
                Title = "تقنيات الحقن الآمنة",
                Description = "تعلم ممارسات الحقن الآمنة مع التركيز على السلامة والوقاية من العدوى",
                category = "مهارات",
                duration = "15 دقيقة",
                publishedDate = "2025-09-13",
                videoUrl = "videos/injection.mp4",
                instructorName = "د. أحمد محمد",
                instructorImage = "img/doctor1.png",
                thumbnailUrl = "img/injection.png",
                CreatedByAdminId = 2
            },

            new training_video
            {
                Id = 2,
                Title = "تضميد الجروح",
                Description = "دليل خطوة بخطوة لتضميد الجروح مع التركيز على النظافة والسلامة",
                category = "مهارات",
                duration = "20 دقيقة",
                publishedDate = "2025-06-23",
                videoUrl = "videos/dressing.mp4",
                instructorName = "د. فاطمة أحمد",
                instructorImage = "img/doctor2.png",
                thumbnailUrl = "img/dressing.png",
                CreatedByAdminId = 2
            },
            new training_video
            {
                Id = 3,
                Title = "قياس العلامات الحيوية",
                Description = "تعلم كيفية قياس النبض وضغط الدم ودرجة الحرارة بدقة",
                category = "طوارئ",
                duration = "25 دقيقة",
                publishedDate = "2025-08-15",
                videoUrl = "videos/vitals.mp4",
                instructorName = "د. محمد علي",
                instructorImage = "img/doctor3.png",
                thumbnailUrl = "img/vitals.png",
                CreatedByAdminId = 1
            },
            new training_video
            {
                Id = 4,
                Title = "التعامل مع حالات الطوارئ",
                Description = "كيفية التعامل مع حالات الطوارئ الطبية والإنعاش القلبي الرئوي",
                category = "طوارئ",
                duration = "30 دقيقة",
                publishedDate = "2025-07-10",
                videoUrl = "videos/emergency.mp4",
                instructorName = "د. سارة محمود",
                instructorImage = "img/doctor4.png",
                thumbnailUrl = "img/emergency.png",
                CreatedByAdminId = 2
            },
            // ICU Videos
            new training_video
            {
                Id = 5,
                Title = "رعاية مرضى العناية المركزة",
                Description = "مبادئ رعاية المرضى في العناية المركزة مع التركيز على المراقبة المستمرة",
                category = "طوارئ",
                duration = "35 دقيقة",
                publishedDate = "2025-05-20",
                videoUrl = "videos/icu_care.mp4",
                instructorName = "د. خالد حسن",
                instructorImage = "img/doctor5.png",
                thumbnailUrl = "img/icu_care.png",
                CreatedByAdminId = 1
            },
            new training_video
            {
                Id = 6,
                Title = "استخدام أجهزة التنفس الصناعي",
                Description = "تعلم كيفية تشغيل ومراقبة أجهزة التنفس الصناعي",
                category = "طوارئ",
                duration = "40 دقيقة",
                publishedDate = "2025-04-15",
                videoUrl = "videos/ventilator.mp4",
                instructorName = "د. مريم عبدالله",
                instructorImage = "img/doctor6.png",
                thumbnailUrl = "img/ventilator.png",
                CreatedByAdminId = 2
            },
            // Pediatrics Videos
            new training_video
            {
                Id = 7,
                Title = "رعاية الأطفال المرضى",
                Description = "مبادئ رعاية الأطفال المرضى مع التركيز على التواصل والراحة النفسية",
                category = "طب الأطفال",
                duration = "28 دقيقة",
                publishedDate = "2025-03-10",
                videoUrl = "videos/pediatrics.mp4",
                instructorName = "د. يوسف إبراهيم",
                instructorImage = "img/doctor7.png",
                thumbnailUrl = "img/pediatrics.png",
                CreatedByAdminId = 1
            },
            new training_video
            {
                Id = 8,
                Title = "حقن الأطفال",
                Description = "تقنيات خاصة لحقن الأطفال مع تقليل الألم والخوف",
                category = "طب الأطفال",
                duration = "22 دقيقة",
                publishedDate = "2025-02-05",
                videoUrl = "videos/pediatric_injection.mp4",
                instructorName = "د. رانيا محمد",
                instructorImage = "img/doctor8.png",
                thumbnailUrl = "img/pediatric_injection.png",
                CreatedByAdminId = 2
            },
            // Surgery Videos
            new training_video
            {
                Id = 9,
                Title = "التمريض الجراحي",
                Description = "مبادئ التمريض في غرف العمليات مع التركيز على التعقيم",
                category = "جراحة",
                duration = "45 دقيقة",
                publishedDate = "2025-01-20",
                videoUrl = "videos/surgical_nursing.mp4",
                instructorName = "د. علي أحمد",
                instructorImage = "img/doctor9.png",
                thumbnailUrl = "img/surgical_nursing.png",
                CreatedByAdminId = 1
            },
            new training_video
            {
                Id = 10,
                Title = "إعداد المريض للجراحة",
                Description = "خطوات إعداد المريض قبل الجراحة مع التركيز على السلامة",
                category = "جراحة",
                duration = "32 دقيقة",
                publishedDate = "2024-12-15",
                videoUrl = "videos/pre_surgery.mp4",
                instructorName = "د. نور الدين",
                instructorImage = "img/doctor10.png",
                thumbnailUrl = "img/pre_surgery.png",
                CreatedByAdminId = 2
            }
        };

            // ================= Quizzes & Questions =================
            public static readonly Quiz[] Quizzes = new[]
            {
            // ICU Quiz
            new Quiz
            {
                Id = 1,
                Title = "اختبار أساسيات العناية المركزة",
                CourseId = 1,
                LectureId = 1,
                UserId = 2
            },
            // Pharmacology Quiz
            new Quiz
            {
                Id = 2,
                Title = "اختبار علم الأدوية",
                CourseId = 2,
                LectureId = 2,
                UserId = 2
            },
            // Anatomy Quiz
            new Quiz
            {
                Id = 3,
                Title = "اختبار التشريح",
                CourseId = 3,
                LectureId = 3,
                UserId = 3
            },
            // Emergency Quiz
            new Quiz
            {
                Id = 4,
                Title = "اختبار الطوارئ الطبية",
                CourseId = 4,
                LectureId = 4,
                UserId = 4
            },
            // Pediatrics Quiz
            new Quiz
            {
                Id = 5,
                Title = "اختبار طب الأطفال",
                CourseId = 5,
                LectureId = 5,
                UserId = 5
            }
        };

            public static readonly Question[] Questions = new[]
            {
            // ICU Questions
                 new Question
            {
                Id = 1,
                hardnessType = hardnessType.easy,
                Text = "ماذا تعني كلمة ICU؟",
                CorrectAnswer = "وحدة العناية المركزة",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "وحدة العناية المركزة", "وحدة الرعاية الداخلية", "وحدة الرعاية الدولية" },
                QuizId = 1
            },
            new Question
            {
                Id = 2,
                hardnessType = hardnessType.medium,
                Text = "ما هو المعدل الطبيعي لضغط الدم؟",
                CorrectAnswer = "120/80 ملم زئبق",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "120/80 ملم زئبق", "140/90 ملم زئبق", "100/60 ملم زئبق" },
                QuizId = 1
            },
            new Question
            {
                Id = 3,
                hardnessType = hardnessType.hard,
                Text = "ما هي مضاعفات استخدام جهاز التنفس الصناعي؟",
                CorrectAnswer = "التهاب رئوي مرتبط بالتنفس الصناعي",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "التهاب رئوي مرتبط بالتنفس الصناعي", "تلف الكبد", "فشل كلوي" },
                QuizId = 1
            },
            // Pharmacology Questions
            new Question
            {
                Id = 4,
                hardnessType = hardnessType.easy,
                Text = "ما هو الاستخدام الرئيسي للباراسيتامول؟",
                CorrectAnswer = "تسكين الألم",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "تسكين الألم", "مضاد حيوي", "مضاد للالتهاب" },
                QuizId = 2
            },
            new Question
            {
                Id = 5,
                hardnessType = hardnessType.medium,
                Text = "ما هي الآثار الجانبية الشائعة للمضادات الحيوية؟",
                CorrectAnswer = "الإسهال",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "الإسهال", "ارتفاع ضغط الدم", "انخفاض السكر" },
                QuizId = 2
            },
            new Question
            {
                Id = 6,
                hardnessType = hardnessType.hard,
                Text = "ما هو آلية عمل حاصرات بيتا؟",
                CorrectAnswer = "منع مستقبلات بيتا الأدرينالية",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "منع مستقبلات بيتا الأدرينالية", "تثبيط مضخة البروتون", "منع قنوات الكالسيوم" },
                QuizId = 2
            },
            // Anatomy Questions
            new Question
            {
                Id = 7,
                hardnessType = hardnessType.easy,
                Text = "كم عدد العظام في جسم الإنسان البالغ؟",
                CorrectAnswer = "206 عظمة",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "206 عظمة", "300 عظمة", "150 عظمة" },
                QuizId = 3
            },
            new Question
            {
                Id = 8,
                hardnessType = hardnessType.medium,
                Text = "ما هو أكبر عضو في جسم الإنسان؟",
                CorrectAnswer = "الجلد",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "الجلد", "الكبد", "الرئتان" },
                QuizId = 3
            },
            // Emergency Questions
            new Question
            {
                Id = 9,
                hardnessType = hardnessType.medium,
                Text = "ما هو أول إجراء في الإنعاش القلبي الرئوي؟",
                CorrectAnswer = "التأكد من سلامة المكان",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "التأكد من سلامة المكان", "بدء الضغطات الصدرية", "إعطاء التنفس الصناعي" },
                QuizId = 4
            },
            new Question
            {
                Id = 10,
                hardnessType = hardnessType.hard,
                Text = "ما هو معدل الضغطات الصدرية في الإنعاش القلبي الرئوي؟",
                CorrectAnswer = "100-120 ضغطة في الدقيقة",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "100-120 ضغطة في الدقيقة", "80-100 ضغطة في الدقيقة", "120-140 ضغطة في الدقيقة" },
                QuizId = 4
            },
            // Pediatrics Questions
            new Question
            {
                Id = 11,
                hardnessType = hardnessType.easy,
                Text = "ما هو المعدل الطبيعي لضربات القلب عند الأطفال؟",
                CorrectAnswer = "80-120 نبضة في الدقيقة",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "80-120 نبضة في الدقيقة", "60-80 نبضة في الدقيقة", "120-160 نبضة في الدقيقة" },
                QuizId = 5
            },
            new Question
            {
                Id = 12,
                hardnessType = hardnessType.medium,
                Text = "ما هي علامات الجفاف عند الأطفال؟",
                CorrectAnswer = "جفاف الفم والعينين",
                Student_Answer = "",
                IsCorrect = false,
                options = new List<string> { "جفاف الفم والعينين", "ارتفاع درجة الحرارة", "زيادة التبول" },
                QuizId = 5
            }
        };

            public static readonly Lecture[] Lectures =
            {
            // ICU Course Lectures
                 new Lecture
                 {
                     Id = 1,
                Title = "مقدمة في العناية المركزة",
                smallDescription = "تعريف بالعناية المركزة وأهميتها",
                bigDescription = "محاضرة شاملة عن العناية المركزة تشمل التعريف والأهداف والمبادئ الأساسية",
                duration = "45 دقيقة",
                videoUrl = "lectures/icu_intro.mp4",
                     CourseId = 1,
                UserId = 2
                 },
                 new Lecture
                 {
                     Id = 2,
                Title = "مراقبة العلامات الحيوية",
                smallDescription = "كيفية مراقبة العلامات الحيوية في العناية المركزة",
                bigDescription = "تعلم كيفية مراقبة وقياس العلامات الحيوية المختلفة للمرضى في العناية المركزة",
                duration = "50 دقيقة",
                videoUrl = "lectures/vital_signs.mp4",
                     CourseId = 1,
                UserId = 2
            },
            // Pharmacology Course Lectures
            new Lecture
            {
                Id = 3,
                Title = "مقدمة في علم الأدوية",
                smallDescription = "تعريف بعلم الأدوية وتصنيفها",
                bigDescription = "محاضرة شاملة عن علم الأدوية تشمل التعريف والتصنيف وآلية العمل",
                duration = "40 دقيقة",
                videoUrl = "lectures/pharma_intro.mp4",
                CourseId = 2,
                UserId = 3
            },
            new Lecture
            {
                Id = 4,
                Title = "المسكنات ومضادات الالتهاب",
                smallDescription = "أنواع المسكنات ومضادات الالتهاب",
                bigDescription = "تعلم أنواع المسكنات المختلفة وآلية عملها ومضادات الالتهاب",
                duration = "55 دقيقة",
                videoUrl = "lectures/analgesics.mp4",
                CourseId = 2,
                UserId = 3
            },
            // Anatomy Course Lectures
            new Lecture
            {
                Id = 5,
                Title = "الجهاز الهيكلي",
                smallDescription = "مقدمة في الجهاز الهيكلي",
                bigDescription = "دراسة شاملة للجهاز الهيكلي تشمل العظام والمفاصل والغضاريف",
                duration = "60 دقيقة",
                videoUrl = "lectures/skeletal_system.mp4",
                CourseId = 3,
                UserId = 4
            },
            new Lecture
            {
                Id = 6,
                Title = "الجهاز العصبي",
                smallDescription = "مقدمة في الجهاز العصبي",
                bigDescription = "دراسة الجهاز العصبي المركزي والمحيطي ووظائفه المختلفة",
                duration = "65 دقيقة",
                videoUrl = "lectures/nervous_system.mp4",
                CourseId = 3,
                UserId = 4
            },
            // Emergency Course Lectures
            new Lecture
            {
                Id = 7,
                Title = "الإنعاش القلبي الرئوي",
                smallDescription = "مبادئ الإنعاش القلبي الرئوي",
                bigDescription = "تعلم خطوات الإنعاش القلبي الرئوي الصحيحة للمرضى البالغين والأطفال",
                duration = "50 دقيقة",
                videoUrl = "lectures/cpr.mp4",
                CourseId = 4,
                UserId = 5
            },
            new Lecture
            {
                Id = 8,
                Title = "التعامل مع حالات الطوارئ",
                smallDescription = "كيفية التعامل مع حالات الطوارئ المختلفة",
                bigDescription = "تعلم كيفية التعامل مع حالات الطوارئ الطبية المختلفة وترتيب الأولويات",
                duration = "45 دقيقة",
                videoUrl = "lectures/emergency_care.mp4",
                CourseId = 4,
                UserId = 5
            },
            // Pediatrics Course Lectures
            new Lecture
            {
                Id = 9,
                Title = "رعاية الأطفال حديثي الولادة",
                smallDescription = "مبادئ رعاية الأطفال حديثي الولادة",
                bigDescription = "تعلم كيفية رعاية الأطفال حديثي الولادة والخدج مع التركيز على السلامة",
                duration = "55 دقيقة",
                videoUrl = "lectures/neonatal_care.mp4",
                CourseId = 5,
                UserId = 6
            },
            new Lecture
            {
                Id = 10,
                Title = "التغذية عند الأطفال",
                smallDescription = "مبادئ التغذية الصحية للأطفال",
                bigDescription = "تعلم مبادئ التغذية الصحية للأطفال في مختلف المراحل العمرية",
                duration = "40 دقيقة",
                videoUrl = "lectures/pediatric_nutrition.mp4",
                CourseId = 5,
                UserId = 6
                 }
             };

            public static readonly LectureMaterial[] LectureMaterials =
            {
            // ICU Materials
                 new LectureMaterial
                 {
                     Id = 1,
                FileName = "مقدمة_العناية_المركزة.pdf",
                FileUrl = "materials/icu_intro.pdf",
                     LectureId = 1
            },
            new LectureMaterial
            {
                Id = 2,
                FileName = "مراقبة_العلامات_الحيوية.pdf",
                FileUrl = "materials/vital_signs.pdf",
                LectureId = 2
            },
            new LectureMaterial
            {
                Id = 3,
                FileName = "جدول_العلامات_الحيوية.xlsx",
                FileUrl = "materials/vital_signs_table.xlsx",
                LectureId = 2
            },
            // Pharmacology Materials
            new LectureMaterial
            {
                Id = 4,
                FileName = "مقدمة_علم_الأدوية.pdf",
                FileUrl = "materials/pharma_intro.pdf",
                LectureId = 3
            },
            new LectureMaterial
            {
                Id = 5,
                FileName = "تصنيف_الأدوية.pdf",
                FileUrl = "materials/drug_classification.pdf",
                LectureId = 3
            },
            new LectureMaterial
            {
                Id = 6,
                FileName = "المسكنات_ومضادات_الالتهاب.pdf",
                FileUrl = "materials/analgesics.pdf",
                LectureId = 4
            },
            // Anatomy Materials
            new LectureMaterial
            {
                Id = 7,
                FileName = "الجهاز_الهيكلي.pdf",
                FileUrl = "materials/skeletal_system.pdf",
                LectureId = 5
            },
            new LectureMaterial
            {
                Id = 8,
                FileName = "صور_تشريحية_للهيكل_العظمي.jpg",
                FileUrl = "materials/skeletal_images.jpg",
                LectureId = 5
            },
            new LectureMaterial
            {
                Id = 9,
                FileName = "الجهاز_العصبي.pdf",
                FileUrl = "materials/nervous_system.pdf",
                LectureId = 6
            },
            // Emergency Materials
            new LectureMaterial
            {
                Id = 10,
                FileName = "دليل_الإنعاش_القلبي_الرئوي.pdf",
                FileUrl = "materials/cpr_guide.pdf",
                LectureId = 7
            },
            new LectureMaterial
            {
                Id = 11,
                FileName = "حالات_الطوارئ_الشائعة.pdf",
                FileUrl = "materials/common_emergencies.pdf",
                LectureId = 8
            },
            // Pediatrics Materials
            new LectureMaterial
            {
                Id = 12,
                FileName = "رعاية_حديثي_الولادة.pdf",
                FileUrl = "materials/neonatal_care.pdf",
                LectureId = 9
            },
            new LectureMaterial
            {
                Id = 13,
                FileName = "التغذية_عند_الأطفال.pdf",
                FileUrl = "materials/pediatric_nutrition.pdf",
                LectureId = 10
                 }
             };

          
    }
}
