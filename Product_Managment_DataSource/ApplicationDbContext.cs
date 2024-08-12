using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Product_Managment_Model;

namespace Product_Managment_DataSource
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action",},
                new Category { CategoryId = 2, Name = "SciFi",},
                new Category { CategoryId = 3, Name = "History",}

                );

			// Configuring the relationship between Product and ApplicationUser
			modelBuilder.Entity<Product>().HasOne(p => p.User).WithMany(u => u.Products).HasForeignKey(p => p.UserId);
		}
    }
}
