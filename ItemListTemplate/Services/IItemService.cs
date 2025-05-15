using ItemListTemplate.DTOs;
using ItemListTemplate.Entities;
using ItemListTemplate.Pagination;

namespace ItemListTemplate.Services
{
    public interface IItemService
    {
        Task<PaginatedResult<Item>> GetItems(PaginationParams request);
    }
}
