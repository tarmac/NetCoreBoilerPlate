using Microsoft.EntityFrameworkCore;
using NetCoreBoilerplate.Entities.Models;

namespace NetCoreBoilerplate.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Message> Message { get; set; }
        public DbSet<MessageType> MessageType { get; set; }
        public DbSet<User> User { get; set; }
    }
}