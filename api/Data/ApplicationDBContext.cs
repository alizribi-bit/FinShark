using api.Models;
using Microsoft.EntityFrameworkCore;


namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions DbContextOptions):base(DbContextOptions)
        {    
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }
}