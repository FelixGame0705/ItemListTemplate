namespace ItemListTemplate.Pagination
{
    public class PaginatedResult<T>
    {
        public List<T> Items { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);
        public bool HasNextPage => PageIndex < TotalPages;
        public bool HasPreviousPage => PageIndex > 1;
    }
}
