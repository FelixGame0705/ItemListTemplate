using ItemListTemplate.DTOs;
using ItemListTemplate.Entities;
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

        public async Task<ResponseItemsDto> GetItems(PaginationParams request)
        {
            var items = await _itemRepository.GetItems(request);
            if (items == null)
            {
                throw new Exception("No items found");
            }
            return new ResponseItemsDto
            {
                items = items.items,
                totalPage = items.totalPage,
                hasNextPage = items.hasNextPage,
                hasPreviousPage = items.hasPreviousPage,
                pageIndex = items.pageIndex,
                pageSize = items.pageSize,
            };
        }
    }
}
