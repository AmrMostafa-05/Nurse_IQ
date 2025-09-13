using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nurse_IQ.Models;

namespace Nurse_IQ.Data
{
    public class AppDbContext : IdentityDbContext<applicationUser, IdentityRole<int>, int>
    {
        public DbSet<applicationUser> applicationUsers { get; set; }
        public DbSet<Announcement> announcements { get; set; }
        public DbSet<Article> articles{ get; set; }
        public DbSet<ContactForm> contactForms { get; set; }
        public DbSet<Diploma> diplomas { get; set; }
        public DbSet<DiplomaFeature> diplomaFeatures { get; set; }
        public DbSet<Forumtopic> forumtopics { get; set; } 
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecture> lectures { get; set; }
        public DbSet<LectureMaterial> lectureMaterials { get; set; }
        public DbSet<MedicalTerm> medicalTerms { get; set; }
        public DbSet<Medicine> medicines{ get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Quiz> quizzes { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<Training> trainings { get; set; }
        public DbSet<training_video> training_Videos{ get; set; }
        public DbSet<UserRegisteredTraining> UserRegisteredTrainings { get; set; }


        public AppDbContext() : base()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetSection("ConnectionStrings:constr").Value;

            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);// to read all the config files
        }
    }
}
