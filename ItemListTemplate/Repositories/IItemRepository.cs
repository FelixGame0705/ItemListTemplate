using ItemListTemplate.DTOs;
using ItemListTemplate.Entities;

namespace ItemListTemplate.Repositories
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        Task<ResponseItemsDto> GetItems(PaginationParams request);
    }
}
