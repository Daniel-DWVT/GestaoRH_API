using Microsoft.EntityFrameworkCore;

namespace GestaoRH_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
    }
}
