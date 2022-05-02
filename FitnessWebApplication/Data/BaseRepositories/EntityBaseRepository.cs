using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FitnessWebApplication.Data.BaseRepositories
{
    public class EntityBaseRepository<G> : IEntityBaseRepository<G> where G : class, IEntityBase, new() 
    {
        private readonly AppDbContext _context;

        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(G entity)
        {
            await _context.Set<G>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<G>().FirstOrDefaultAsync(m => m.Id == id);
            EntityEntry entityEntry = _context.Entry<G>(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<G>> GetAllAsync()
        {
            var outcome = await _context.Set<G>().ToListAsync();
            return outcome;
        }

        public async Task<IEnumerable<G>> GetAllAsync(params Expression<Func<G, object>>[] includeProperties)
        {
            IQueryable<G> query = _context.Set<G>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();
        }

        public async Task<G> GetByIdAsync(int id)
        {
            var outcome = await _context.Set<G>().FirstOrDefaultAsync(m => m.Id == id);
            return outcome;
        }

        public async Task UpdateAsync(int id, G entity)
        {
            EntityEntry entityEntry = _context.Entry<G>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    
    }
}
