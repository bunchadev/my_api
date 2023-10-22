using Microsoft.EntityFrameworkCore;

namespace API_PTTTHDT_.Controllers
{
    public class DevDbContext : DbContext
    {
        public DevDbContext(DbContextOptions<DevDbContext> options) : base(options)
        {
            
        }
    }
}
