using BookStore.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDBContext:IdentityDbContext<UserList>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var customer = new IdentityRole("customer");
            customer.NormalizedName = "customer";

            builder.Entity<IdentityRole>().HasData(admin, customer);
        }

        public DbSet<BookMaster> MasterBooks { get; set; }
        public DbSet<BookRating> BookRatings { get; set; }
        public DbSet<UserList> UserLists { get; set; }
        public DbSet<OrderDetails>orderDetails { get; set; }
        public DbSet<BookCategory>bookCategories { get; set; }
        public DbSet<Registers> registers { get; set; }
    }
}
