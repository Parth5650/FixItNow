using FixItNow.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace FixItNow.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ServiceCategory>().HasData(
                new ServiceCategory { Id = 1, Name = "Electrical" },
                new ServiceCategory { Id = 2, Name = "Plumbing" },
                new ServiceCategory { Id = 3, Name = "Home Moving" },
                new ServiceCategory { Id = 4, Name = "Carpentry" },
                new ServiceCategory { Id = 5, Name = "Furniture Assembly" },
                new ServiceCategory { Id = 6, Name = "Home Repairs" },
                new ServiceCategory { Id = 7, Name = "Heavy Lifting" },
                new ServiceCategory { Id = 8, Name = "Home Cleaning" },
                new ServiceCategory { Id = 9, Name = "Personal Assistant" },
                new ServiceCategory { Id = 10, Name = "General Mounting" },
                new ServiceCategory { Id = 11, Name = "Flooring & Tiling" },
                new ServiceCategory { Id = 12, Name = "Sealing & Caulking" },
                new ServiceCategory { Id = 13, Name = "Windows & Blinds" },
                new ServiceCategory { Id = 14, Name = "Smart Home" },
                new ServiceCategory { Id = 15, Name = "Painting" },
                new ServiceCategory { Id = 16, Name = "Shelves & Hooks" },
                new ServiceCategory { Id = 17, Name = "Maintenance" },
                new ServiceCategory { Id = 18, Name = "Baby Proofing" },
                new ServiceCategory { Id = 19, Name = "Yardwork & Landscaping" },
                new ServiceCategory { Id = 20, Name = "Light Installation" },
                new ServiceCategory { Id = 21, Name = "Cabinets" },
                new ServiceCategory { Id = 22, Name = "Wallpapering" },
                new ServiceCategory { Id = 23, Name = "Fence & Deck" },
                new ServiceCategory { Id = 24, Name = "Doorbell & Home Theater" },
                new ServiceCategory { Id = 25, Name = "Packing & Moving Help" },
                new ServiceCategory { Id = 26, Name = "Junk Removal" },
                new ServiceCategory { Id = 27, Name = "Organization" },
                new ServiceCategory { Id = 28, Name = "Delivery & Errands" },
                new ServiceCategory { Id = 29, Name = "IKEA Services" },
                new ServiceCategory { Id = 30, Name = "Virtual & Online" },
                new ServiceCategory { Id = 31, Name = "Office Services" },
                new ServiceCategory { Id = 32, Name = "Contactless Tasks" },
                new ServiceCategory { Id = 33, Name = "Holidays & Seasonal" },
                new ServiceCategory { Id = 34, Name = "Winter Tasks" }
            );

            modelBuilder.Entity<Service>().HasData(
                // Electrical
                new Service { Id = 1, Name = "Ceiling Fan Repair", CategoryId = 1, Description = "Fix and balance ceiling fans", Price = 300m },
                new Service { Id = 2, Name = "TV Mounting", CategoryId = 1, Description = "Wall mount LED/LCD/Smart TVs", Price = 500m },
                new Service { Id = 5, Name = "Light Installation", CategoryId = 20, Description = "Install or replace light fixtures", Price = 450m },
                new Service { Id = 6, Name = "Ceiling Fan Installation", CategoryId = 1, Description = "Install new ceiling fans", Price = 650m },
                new Service { Id = 7, Name = "Smart Switch/Dimmer Setup", CategoryId = 14, Description = "Install smart switches and dimmers", Price = 550m },

                // Plumbing
                new Service { Id = 3, Name = "Pipe Leak Repair", CategoryId = 2, Description = "Fix leaking pipes and joints", Price = 400m },
                new Service { Id = 8, Name = "Sealing & Caulking", CategoryId = 12, Description = "Seal bathtubs, sinks, windows", Price = 350m },
                new Service { Id = 9, Name = "Install Water Filter", CategoryId = 2, Description = "Mount and connect water filters", Price = 700m },

                // Moving / Heavy lifting
                new Service { Id = 4, Name = "House Shifting (Local)", CategoryId = 3, Description = "Local house shifting services", Price = 2000m },
                new Service { Id = 10, Name = "Help Moving", CategoryId = 25, Description = "Assist with packing, loading, unloading", Price = 1500m },
                new Service { Id = 11, Name = "Heavy Lifting", CategoryId = 7, Description = "Move heavy furniture and appliances", Price = 800m },
                new Service { Id = 12, Name = "Furniture Movers", CategoryId = 3, Description = "Move furniture within or between homes", Price = 1200m },
                new Service { Id = 13, Name = "Junk Pickup", CategoryId = 26, Description = "Pickup and dispose unwanted items", Price = 900m },

                // Furniture assembly
                new Service { Id = 14, Name = "Patio Furniture Assembly", CategoryId = 5, Description = "Assemble outdoor sets", Price = 600m },
                new Service { Id = 15, Name = "Desk Assembly", CategoryId = 5, Description = "Assemble office and gaming desks", Price = 450m },
                new Service { Id = 16, Name = "Dresser Assembly", CategoryId = 5, Description = "Assemble dressers and chests", Price = 500m },
                new Service { Id = 17, Name = "Bed Assembly", CategoryId = 5, Description = "Assemble beds and frames", Price = 550m },
                new Service { Id = 18, Name = "Bookshelf Assembly", CategoryId = 5, Description = "Assemble bookshelves and storage units", Price = 400m },
                new Service { Id = 19, Name = "Wardrobe Assembly", CategoryId = 5, Description = "Assemble wardrobes/closets", Price = 700m },

                // Mounting & installation
                new Service { Id = 20, Name = "Install Shelves, Rods & Hooks", CategoryId = 16, Description = "Install shelves and closet rods", Price = 350m },
                new Service { Id = 21, Name = "Install Blinds & Window Treatments", CategoryId = 13, Description = "Mount blinds and curtains", Price = 500m },
                new Service { Id = 22, Name = "Hang Art, Mirror & Decor", CategoryId = 10, Description = "Mount frames, mirrors, and decor", Price = 300m },
                new Service { Id = 23, Name = "General Mounting", CategoryId = 10, Description = "Mounting for various items", Price = 300m },

                // Home repairs
                new Service { Id = 24, Name = "Drywall Repair", CategoryId = 6, Description = "Patch and smooth drywall", Price = 650m },
                new Service { Id = 25, Name = "Window & Blinds Repair", CategoryId = 13, Description = "Repair window hardware & blinds", Price = 450m },
                new Service { Id = 26, Name = "Door, Cabinet, & Furniture Repair", CategoryId = 6, Description = "Fix hinges, handles, drawers", Price = 550m },
                new Service { Id = 27, Name = "Appliance Installation & Repairs", CategoryId = 6, Description = "Install or fix appliances", Price = 900m },

                // Cleaning
                new Service { Id = 28, Name = "House Cleaning", CategoryId = 8, Description = "Standard home cleaning", Price = 800m },
                new Service { Id = 29, Name = "Deep Cleaning", CategoryId = 8, Description = "Intensive deep clean", Price = 1200m },
                new Service { Id = 30, Name = "Move In/Out Cleaning", CategoryId = 8, Description = "Cleaning for moving", Price = 1000m },
                new Service { Id = 31, Name = "Carpet Cleaning", CategoryId = 8, Description = "Shampoo and clean carpets", Price = 900m },

                // Yardwork & outdoor
                new Service { Id = 32, Name = "Gardening Services", CategoryId = 19, Description = "Planting, weeding, pruning", Price = 700m },
                new Service { Id = 33, Name = "Lawn Care & Mowing", CategoryId = 19, Description = "Mow and edge lawns", Price = 600m },
                new Service { Id = 34, Name = "Gutter Cleaning", CategoryId = 19, Description = "Clear and flush gutters", Price = 550m },
                new Service { Id = 35, Name = "Fence Installation & Repair", CategoryId = 23, Description = "Install or fix fences", Price = 2000m },

                // Organization & assistant
                new Service { Id = 36, Name = "Closet Organization", CategoryId = 27, Description = "Declutter and organize closets", Price = 700m },
                new Service { Id = 37, Name = "Personal Assistant", CategoryId = 9, Description = "Errands, scheduling, admin tasks", Price = 500m },
                new Service { Id = 38, Name = "Wait in Line", CategoryId = 28, Description = "Queue on your behalf", Price = 250m },
                new Service { Id = 39, Name = "Grocery Shopping & Delivery", CategoryId = 28, Description = "Shop and deliver groceries", Price = 300m },

                // Painting & flooring
                new Service { Id = 40, Name = "Interior Painting", CategoryId = 15, Description = "Paint rooms and interiors", Price = 2500m },
                new Service { Id = 41, Name = "Flooring & Tiling Help", CategoryId = 11, Description = "Install or repair tiles/flooring", Price = 3000m },

                // Smart home
                new Service { Id = 42, Name = "Smart Home Installation", CategoryId = 14, Description = "Set up smart devices/hubs", Price = 1200m },

                // Seasonal / holiday / winter
                new Service { Id = 43, Name = "Hang Christmas Lights", CategoryId = 33, Description = "Install and remove lights", Price = 700m },
                new Service { Id = 44, Name = "Snow Removal", CategoryId = 34, Description = "Clear snow from paths and drives", Price = 900m }
            );

            // Relationships
            modelBuilder.Entity<ServiceCategory>()
                .HasMany(c => c.Services)
                .WithOne(s => s.Category)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Service>()
                .HasMany(s => s.ServiceRequests)
                .WithOne(r => r.Service)
                .HasForeignKey(r => r.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(u => u.ServiceRequests)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.SetNull);

            // Seed default admin user (username: admin, password: 0000)
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", Email = "admin@fixitnow.com", PhoneNumber = "+10000000000", ZipCode = "00000", PasswordHash = "0000", IsAdmin = true }
            );
        }
    }
}
