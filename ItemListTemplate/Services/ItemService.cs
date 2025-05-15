using ItemListTemplate.DTOs;
using ItemListTemplate.Entities;
using ItemListTemplate.Pagination;
using ItemListTemplate.Repositories;

namespace ItemListTemplate.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<PaginatedResult<Item>> GetItems(PaginationParams request)
        {
            var items = await _itemRepository.GetPagedAsync(request);
            if (items == null)
            {
                throw new Exception("No items found");
            }
            return items;
        }
    }
}
