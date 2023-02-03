using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SupportDashAI.Domain.Entities;

namespace SupportDashAI.EfCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<AgentResponse> AgentResponses { get; set; }
        public DbSet<AgentResponseTip> AgentResponseTips { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerRequest> CustomerRequests { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<FeatureSetting> FeatureSettings { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            string ADMIN_ID = "c09ca40f-c617-43dd-a22b-2342fae14b75";
            string ROLE_ID = "48a3a5ea-799f-4e04-be28-1a3a2b528f5e";

            //seed admin role
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            //create user
            var appUser = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "admin@supportdash.ai",
                NormalizedEmail = "admin@supportdash.ai",
                EmailConfirmed = true,
                UserName = "admin@supportdash.ai",
                NormalizedUserName = "Admin@SupportDash.ai"
            };

            //set user password
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "admin");

            //seed user
            builder.Entity<IdentityUser>().HasData(appUser);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}