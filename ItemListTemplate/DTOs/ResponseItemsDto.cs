using ItemListTemplate.Entities;

namespace ItemListTemplate.DTOs
{
    public class ResponseItemsDto
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public int totalPage { get; set; }
        public bool hasNextPage { get; set; }
        public bool hasPreviousPage { get; set; }
        public List<Item> items { get; set; } = new List<Item>();
    }
}
