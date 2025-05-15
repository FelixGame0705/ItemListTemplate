namespace ItemListTemplate.DTOs
{
    public class PaginationParams
    {
        public string sortBy { get; set; } = "Id";
        public bool isSortDescending { get; set; } = false;
        public int pageNummber { get; set; } = 1;
        public int pageSize { get; set; } = 10;
    }
}
