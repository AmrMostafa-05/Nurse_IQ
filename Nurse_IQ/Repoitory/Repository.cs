using Microsoft.EntityFrameworkCore;
    using Nurse_IQ.Data;
    using System.Collections.Generic;
    using System.Linq;
namespace Nurse_IQ.Repoitory
{

        public class Repository<T> : IRepository<T> where T : class
        {
            private readonly AppDbContext _context;
            private readonly DbSet<T> _dbSet;

            public Repository(AppDbContext context)
            {
                _context = context;
                _dbSet = _context.Set<T>();
            }

            public void Add(T entity)
            {
                _dbSet.Add(entity);
            }

            public void Update(T entity)
            {
                _dbSet.Update(entity);
            }

            public void Delete(int id)
            {
                var entity = _dbSet.Find(id);
                if (entity != null)
                    _dbSet.Remove(entity);
            }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> CountAsync()
        {
            return await _dbSet.CountAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
