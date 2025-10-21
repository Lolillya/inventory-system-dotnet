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
using backend.Models.InvoiceModel;
using backend.Models.RestockModel;
using backend.Models.LineItems;

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
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceLineItems> InvoiceLineItems { get; set; }
        public DbSet<RestockLineItems> RestockLineItems { get; set; }
        public DbSet<Restock> Restocks { get; set; }
        public DbSet<RestockBatch> RestocksBatch { get; set; }

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
            Seeders.SeedInvoice.SeedInvoiceData(builder);

            builder.Entity<Invoice>(entity =>
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

            builder.Entity<Restock>(entity =>
            {
                entity.ToTable("Restock");

                entity.HasOne(r => r.Clerk)
                    .WithMany()
                    .HasForeignKey(r => r.Restock_Clerk)
                    .OnDelete(DeleteBehavior.NoAction);

                // Restock has many LineItems
                entity.HasMany(r => r.LineItems)
                    .WithOne(li => li.Restock)
                    .HasForeignKey("Restock_ID")
                    .OnDelete(DeleteBehavior.NoAction);

            });

            builder.Entity<RestockLineItems>(entity =>
            {
                entity.ToTable("RestockLineItems");

                entity.HasOne(li => li.Product)
                    .WithMany()
                    .HasForeignKey(li => li.Product_ID)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(li => li.Restock)
                    .WithMany()
                    .HasForeignKey(li => li.Restock_ID)
                    .OnDelete(DeleteBehavior.NoAction);

            });

        }
    }
}