using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Persistance.Context
{
    public class UserMangagementDbContext : IdentityDbContext<IdentityUser>
    {
        public UserMangagementDbContext(DbContextOptions<UserMangagementDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
        }
        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                 new IdentityRole { Name = "Developer", ConcurrencyStamp = "2", NormalizedName = "Developer" },
                  new IdentityRole { Name = "Product Owner", ConcurrencyStamp = "3", NormalizedName = "Product Owner" },
                   new IdentityRole { Name = "Product Manager", ConcurrencyStamp = "3", NormalizedName = "Product Owner" }
                );
        }
    }
}
