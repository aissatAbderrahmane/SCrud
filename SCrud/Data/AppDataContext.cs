using Microsoft.EntityFrameworkCore;
using SCrud.Models;

namespace SCrud.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> cxt) : base(cxt)
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
