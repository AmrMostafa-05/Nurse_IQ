using Nurse_IQ.Models;
using Nurse_IQ.Repoitory;

namespace Nurse_IQ.UnityOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        // Repositories
        IRepository<Course> Courses { get; }
        IRepository<Article> articles { get; }
        IRepository<Announcement> announcements { get; }
        IRepository<Training> trainings { get; }
        IRepository<applicationUser> applicationUsers { get; }
        IRepository<ContactForm> contactForms { get; }
        IRepository<Diploma> diplomas { get; }
        IRepository<DiplomaFeature> diplomaFeatures { get; }
        IRepository<Forumtopic> forumtopics { get; }
        IRepository<Lecture> lectures { get; }
        IRepository<LectureMaterial> lectureMaterials { get; }
        IRepository<MedicalTerm> medicalTerms { get; }
        IRepository<Medicine> medicines { get; }
        IRepository<Offer> Offers { get; }
        IRepository<Quiz> quizzes { get; }
        IRepository<Question> questions { get; }
        IRepository<training_video> training_Videos { get; }
        IRepository<UserRegisteredTraining> UserRegisteredTrainings { get; }

        // Save methods
        int Save();
        Task<int> SaveAsync();
    }
}
