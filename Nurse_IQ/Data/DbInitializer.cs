using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Nurse_IQ.Models;
using Nurse_IQ.Enums.User; // Ensure this is included for role enum

namespace Nurse_IQ.Data
{
    public static class DbInitializer
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<AppDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<applicationUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();

            // Ensure database is created and migrations are applied
            await context.Database.MigrateAsync();

            // Seed Roles
            await SeedRolesAsync(roleManager);

            // Seed Users
            await SeedUsersAsync(userManager);

            // Seed All Data
            await SeedAllDataAsync(context);
        }

        private static async Task SeedRolesAsync(RoleManager<IdentityRole<int>> roleManager)
        {
            string[] roleNames = Enum.GetNames(typeof(role));
            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole<int>(roleName));
                }
            }
        }

        private static async Task SeedUsersAsync(UserManager<applicationUser> userManager)
        {
            foreach (var userData in SeedData.Users)
            {
                if (await userManager.FindByEmailAsync(userData.Email) == null)
                {
                    var user = new applicationUser
                    {
                        UserName = userData.Email,
                        Email = userData.Email,
                        // FullName = userData.FullName, // Remove or comment out this line
                        PhoneNumber = userData.PhoneNumber,
                        gender = userData.gender,
                        role = userData.role,
                        Year_Level = userData.Year_Level,
                        Type_of_Educational_institution = userData.Type_of_Educational_institution,
                        interests_Fields = userData.interests_Fields,
                        EmailConfirmed = true,
                        Fname = userData.Fname, // Set Fname
                        Lname = userData.Lname  // Set Lname
                        // FullName will be computed automatically by the applicationUser class
                    };

                    var result = await userManager.CreateAsync(user, "123456"); // Default password
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, userData.role.ToString());
                    }
                }
            }
        }

        private static async Task SeedAllDataAsync(AppDbContext context)
        {
            // Seed Courses if not exists
            if (!await context.Courses.AnyAsync())
            {
                await context.Courses.AddRangeAsync(SeedData.Courses);
                await context.SaveChangesAsync();
            }

            // Seed Articles if not exists
            if (!await context.articles.AnyAsync())
            {
                await context.articles.AddRangeAsync(SeedData.Articles);
                await context.SaveChangesAsync();
            }

            // Seed Announcements if not exists
            if (!await context.announcements.AnyAsync())
            {
                await context.announcements.AddRangeAsync(SeedData.Announcements);
                await context.SaveChangesAsync();
            }

            // Seed Contact Forms if not exists
            if (!await context.contactForms.AnyAsync())
            {
                await context.contactForms.AddRangeAsync(SeedData.ContactForms);
                await context.SaveChangesAsync();
            }

            // Seed Diplomas if not exists
            if (!await context.diplomas.AnyAsync())
            {
                await context.diplomas.AddRangeAsync(SeedData.Diplomas);
                await context.SaveChangesAsync();
            }

            // Seed Diploma Features if not exists
            if (!await context.diplomaFeatures.AnyAsync())
            {
                await context.diplomaFeatures.AddRangeAsync(SeedData.DiplomaFeatures);
                await context.SaveChangesAsync();
            }

            // Seed Forum Topics if not exists
            if (!await context.forumtopics.AnyAsync())
            {
                await context.forumtopics.AddRangeAsync(SeedData.Forumtopics);
                await context.SaveChangesAsync();
            }

            // Seed Lectures if not exists
            if (!await context.lectures.AnyAsync())
            {
                await context.lectures.AddRangeAsync(SeedData.Lectures);
                await context.SaveChangesAsync();
            }

            // Seed Lecture Materials if not exists
            if (!await context.lectureMaterials.AnyAsync())
            {
                await context.lectureMaterials.AddRangeAsync(SeedData.LectureMaterials);
                await context.SaveChangesAsync();
            }

            // Seed Medical Terms if not exists
            if (!await context.medicalTerms.AnyAsync())
            {
                await context.medicalTerms.AddRangeAsync(SeedData.MedicalTerms);
                await context.SaveChangesAsync();
            }

            // Seed Medicines if not exists
            if (!await context.medicines.AnyAsync())
            {
                await context.medicines.AddRangeAsync(SeedData.Medicines);
                await context.SaveChangesAsync();
            }

            // Seed Offers if not exists
            if (!await context.Offers.AnyAsync())
            {
                await context.Offers.AddRangeAsync(SeedData.Offers);
                await context.SaveChangesAsync();
            }

            // Seed Trainings if not exists
            if (!await context.trainings.AnyAsync())
            {
                await context.trainings.AddRangeAsync(SeedData.Trainings);
                await context.SaveChangesAsync();
            }

            // Seed Training Videos if not exists
            if (!await context.training_Videos.AnyAsync())
            {
                await context.training_Videos.AddRangeAsync(SeedData.TrainingVideos);
                await context.SaveChangesAsync();
            }

            // Seed Quizzes if not exists
            if (!await context.quizzes.AnyAsync())
            {
                await context.quizzes.AddRangeAsync(SeedData.Quizzes);
                await context.SaveChangesAsync();
            }

            // Seed Questions if not exists
            if (!await context.questions.AnyAsync())
            {
                await context.questions.AddRangeAsync(SeedData.Questions);
                await context.SaveChangesAsync();
            }

            // Seed User Registered Trainings if not exists
            if (!await context.UserRegisteredTrainings.AnyAsync())
            {
                await context.UserRegisteredTrainings.AddRangeAsync(SeedData.UserRegisteredTrainings);
                await context.SaveChangesAsync();
            }
        }
    }
}