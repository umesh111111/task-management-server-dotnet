using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskManagement.Model;

namespace TaskManagement
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<StoryTask> StoryTask { get; set; }

    }
}
