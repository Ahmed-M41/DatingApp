namespace API.Data
{
    using Microsoft.EntityFrameworkCore;
    using Entities;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}