using System.Collections.Generic;
using ItemListTemplate.Pagination;
using Microsoft.EntityFrameworkCore;

namespace ItemListTemplate.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        protected readonly ItemDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(ItemDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T?> GetByIdAsync(Guid id) => await _dbSet.FindAsync(id);

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

        public async Task Update(T entity) => _dbSet.Update(entity);

        public async Task Delete(T entity) => _dbSet.Remove(entity);

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

        public async Task<PaginatedResult<T>> GetPagedAsync(PaginationParams paging)
        {
            var query = _dbSet.AsQueryable();

            // Optional: apply default sorting
            if (!string.IsNullOrEmpty(paging.SortBy))
            {
                query = paging.IsDescending
                    ? query.OrderByDescending(e => EF.Property<object>(e, paging.SortBy))
                    : query.OrderBy(e => EF.Property<object>(e, paging.SortBy));
            }

            var count = await query.CountAsync();
            var items = await query
                .Skip((paging.PageNumber - 1) * paging.PageSize)
                .Take(paging.PageSize)
                .ToListAsync();

            return new PaginatedResult<T>
            {
                Items = items,
                PageIndex = paging.PageNumber,
                PageSize = paging.PageSize,
                TotalItems = count,
            };
        }
    }
}
