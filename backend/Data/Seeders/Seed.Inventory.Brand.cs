using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.Inventory;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.Seeders;

public static class BrandInventory
{
    public static void SeedBrandData(ModelBuilder modelBuilder)
    {
        var brands = new List<Brand>
        {
            new Brand
            {
                Brand_Id = 1,
                BrandName = "Pilot",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        };

        modelBuilder.Entity<Brand>().HasData(brands);
    }
}
