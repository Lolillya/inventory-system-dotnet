using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models.Inventory;
using backend.Models.Invoice;

namespace backend.Data
{
    public class ApplicationDBContext : IdentityDbContext<PersonalDetails>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<backend.Models.Inventory.Inventory> Inventories { get; set; }
        public DbSet<backend.Models.Invoice.Invoice> Invoice { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            // Seed roles
            Seeders.Roles.SeedRoles(builder);

            // Seed users
            Seeders.Users.UserDataSeed(builder);
            Seeders.Suppliers.SeedSupplierUsers(builder);

            // Inventory items
            Seeders.BrandInventory.SeedBrandData(builder);
            Seeders.CategoryInventory.SeedCategoryData(builder);
            Seeders.InventoryProduct.SeedProductData(builder);
            Seeders.SeedInventory.SeedInventoryData(builder);
            Seeders.VariantInventory.SeedVariantData(builder);

            builder.Entity<backend.Models.Invoice.Invoice>(entity =>
            {
                entity.ToTable("Invoice"); // optional, matches your table name

                entity.HasOne(i => i.Customer)
                    .WithMany() // no inverse navigation on PersonalDetails
                    .HasForeignKey(i => i.Customer_ID)
                    .OnDelete(DeleteBehavior.NoAction); // or .Restrict

                entity.HasOne(i => i.Clerk)
                    .WithMany()
                    .HasForeignKey(i => i.Invoice_Clerk)
                    .OnDelete(DeleteBehavior.NoAction); // or .Restrict
            });

        }
    }
}