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
        var seededAt = new DateTime(2025, 01, 01, 00, 00, 00, DateTimeKind.Utc);
        var variant = new List<Variant>
        {
            new Variant
            {
                Variant_ID = 1,
                Product_ID = 1,
                Variant_Name = "Single Pack",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            }
        };
        modelBuilder.Entity<Variant>().HasData(variant);
    }
}
