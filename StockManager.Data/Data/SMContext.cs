using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using StockManager.Data.Data.Entities;

namespace StockManager.Data.Data
{
    public class SMContext : IdentityDbContext<User>
    {
        public SMContext(DbContextOptions<SMContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
