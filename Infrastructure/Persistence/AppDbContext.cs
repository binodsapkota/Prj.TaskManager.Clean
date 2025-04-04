using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Entities;

namespace Infrastructure.Persistence
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }

}
