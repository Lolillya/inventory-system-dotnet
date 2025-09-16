using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.Inventory;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.Seeders;

public static class SeedInventory
{
    public static void SeedInventoryData(ModelBuilder modelBuilder)
    {
        var seededAt = new DateTime(2025, 01, 01, 00, 00, 00, DateTimeKind.Utc);
        var inventory = new List<Inventory>
        {
            new Inventory {
                Inventory_ID = 1,
                Variant_ID = 1,
                Total_Quantity = 0,
                Inventory_Number = 0,
                Created_At = seededAt,
                Updated_At = seededAt
            }
        };

        modelBuilder.Entity<Inventory>().HasData(inventory);
    }
}
