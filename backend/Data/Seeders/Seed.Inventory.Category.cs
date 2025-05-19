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
        var category = new List<Category>
        {
            new Category
            {
                Category_Id = 1,
                Category_Name = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        };

        modelBuilder.Entity<Category>().HasData(category);

    }
}
