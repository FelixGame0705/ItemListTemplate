namespace ItemListTemplate.Pagination
{
    public class PaginationParams
    {
        public string SortBy { get; set; } = "Id";
        public bool IsDescending { get; set; } = false;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
