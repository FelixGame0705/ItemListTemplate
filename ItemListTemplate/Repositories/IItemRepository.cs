using ItemListTemplate.DTOs;
using ItemListTemplate.Entities;
using ItemListTemplate.Pagination;

namespace ItemListTemplate.Repositories
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        Task<ResponseItemsDto> GetItems(PaginationParams request);
    }
}
