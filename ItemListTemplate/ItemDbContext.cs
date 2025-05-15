using ItemListTemplate.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItemListTemplate
{
    public partial class ItemDbContext : DbContext
    {
        public ItemDbContext(DbContextOptions<ItemDbContext> options)
            : base(options) { }

        public virtual DbSet<Item> Items { get; set; }
    }
}
