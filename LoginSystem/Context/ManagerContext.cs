using Microsoft.EntityFrameworkCore;
using LoginSystem.Models;

namespace LoginSystem.Context 
{
    public class ManagerContext: DbContext
    {
        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        
    }
}