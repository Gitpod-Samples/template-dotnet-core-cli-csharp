using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions options) : base(options) {}

        public required DbSet<User> User { get; set; }
    }
}