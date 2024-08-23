using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions options) : base(options) {}

        public DbSet<User> User { get; set; }
    }
}