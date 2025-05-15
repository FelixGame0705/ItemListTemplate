using ItemListTemplate.Pagination;

namespace ItemListTemplate.Repositories
{
    public interface IGenericRepository<T>
        where T : class
    {
        Task<T?> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task SaveChangesAsync();
        Task<PaginatedResult<T>> GetPagedAsync(PaginationParams pagingParams);
    }
}
