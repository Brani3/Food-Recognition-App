using Microsoft.EntityFrameworkCore;
using FoodRecognitionAppC_.Models;

namespace FoodRecognitionAppC_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> users { get; set; }
    }
}

