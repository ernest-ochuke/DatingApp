using DatingApp.Api2.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Api2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}

        public DbSet<Value> Values { get; set; }
       
    }
}