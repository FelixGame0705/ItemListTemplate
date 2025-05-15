using ItemListTemplate.DTOs;
using ItemListTemplate.Entities;

namespace ItemListTemplate.Services
{
    public interface IItemService
    {
        Task<ResponseItemsDto> GetItems(PaginationParams request);
    }
}
