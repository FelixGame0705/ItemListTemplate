using System.Globalization;
using ItemListTemplate.DTOs;
using ItemListTemplate.Entities;
using ItemListTemplate.Models;
using ItemListTemplate.Pagination;

namespace ItemListTemplate.Repositories
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        public ItemRepository(ItemDbContext context)
            : base(context) { }

        public async Task<ResponseItemsDto> GetItems(PaginationParams request)
        {
            var items = _dbSet.AsQueryable();
            items.OrderBy(x => x.Id);
            if (!string.IsNullOrEmpty(request.SortBy))
            {
                switch (request.SortBy)
                {
                    case "Name":
                        items = items.OrderBy(hh => hh.Name);
                        break;
                }
            }
            var result = PaginatedList<Item>.Create(items, request.PageNumber, request.PageSize);
            return new ResponseItemsDto
            {
                items = result,
                totalPage = result.TotalPage,
                pageIndex = result.PageIndex,
                pageSize = result.Count,
                hasNextPage = result.HasNextPage,
                hasPreviousPage = result.HasPreviousPage,
            };
        }
    }
}
