using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.Inventory;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.Seeders;

public static class VariantInventory
{
    public static void SeedVariantData(ModelBuilder modelBuilder)
    {
        var variant = new List<Variant>
        {
            new Variant
            {
                Variant_Id = 1,
                Product_Id = 1,
                Variant_Name = "",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        };
        modelBuilder.Entity<Variant>().HasData(variant);
    }
}
