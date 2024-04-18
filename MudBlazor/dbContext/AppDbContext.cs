using Microsoft.EntityFrameworkCore;
using MudBlazor.Models;

namespace MudBlazor.dbcontext
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"Data Source=DataBase\MudBlazor.db");

        public DbSet<Quote> quotes { get; set; }
    }
}
