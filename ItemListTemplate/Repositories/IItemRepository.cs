using ItemListTemplate.DTOs;
using ItemListTemplate.Entities;
using ItemListTemplate.Pagination;

namespace ItemListTemplate.Repositories
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        //Task<PaginatedResult<Item>> GetItems(PaginationParams request);
    }
}
