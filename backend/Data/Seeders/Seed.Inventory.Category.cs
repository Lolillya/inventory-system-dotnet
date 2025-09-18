using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.Inventory;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.Seeders;

public static class CategoryInventory
{
    public static void SeedCategoryData(ModelBuilder modelBuilder)
    {
        var seededAt = new DateTime(2025, 01, 01, 00, 00, 00, DateTimeKind.Utc);
        var category = new List<Category>
        {
            new Category
            {
                Category_ID = 1,
                Category_Name = "Writing Instruments",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Category
            {
                Category_ID = 2,
                Category_Name = "Art Supplies",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Category
            {
                Category_ID = 3,
                Category_Name = "Notebooks & Paper",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Category
            {
                Category_ID = 4,
                Category_Name = "Office Supplies",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Category
            {
                Category_ID = 5,
                Category_Name = "Classroom Tools",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Category
            {
                Category_ID = 6,
                Category_Name = "Storage & Organization",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Category
            {
                Category_ID = 7,
                Category_Name = "Technology Accessories",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Category
            {
                Category_ID = 8,
                Category_Name = "Science & Lab Supplies",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            }
        };

        modelBuilder.Entity<Category>().HasData(category);

    }
}
