using Nurse_IQ.Data;
using Nurse_IQ.Models;
using Nurse_IQ.Repoitory;

namespace Nurse_IQ.UnityOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly Dictionary<Type, object> _repositories;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
        }

        // Repositories
        public IRepository<Course> Courses => GetRepository<Course>();
        public IRepository<Article> articles => GetRepository<Article>();
        public IRepository<Announcement> announcements => GetRepository<Announcement>();
        public IRepository<Training> trainings => GetRepository<Training>();
        public IRepository<applicationUser> applicationUsers => GetRepository<applicationUser>();
        public IRepository<ContactForm> contactForms => GetRepository<ContactForm>();
        public IRepository<Diploma> diplomas => GetRepository<Diploma>();
        public IRepository<DiplomaFeature> diplomaFeatures => GetRepository<DiplomaFeature>();
        public IRepository<Forumtopic> forumtopics => GetRepository<Forumtopic>();
        public IRepository<Lecture> lectures => GetRepository<Lecture>();
        public IRepository<LectureMaterial> lectureMaterials => GetRepository<LectureMaterial>();
        public IRepository<MedicalTerm> medicalTerms => GetRepository<MedicalTerm>();
        public IRepository<Medicine> medicines => GetRepository<Medicine>();
        public IRepository<Offer> Offers => GetRepository<Offer>();
        public IRepository<Quiz> quizzes => GetRepository<Quiz>();
        public IRepository<Question> questions => GetRepository<Question>();
        public IRepository<training_video> training_Videos => GetRepository<training_video>();
        public IRepository<UserRegisteredTraining> UserRegisteredTrainings => GetRepository<UserRegisteredTraining>();

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);
            if (!_repositories.ContainsKey(type))
            {
                _repositories[type] = new Repository<T>(_context);
            }
            return (IRepository<T>)_repositories[type];
        }

        public int Save() => _context.SaveChanges();
        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
