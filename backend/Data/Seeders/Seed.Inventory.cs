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
        var inventory = new List<Inventory>
        {
            new Inventory {
                Inventory_Id = 1,
                Variant_Id = 1,
                Total_Quantity = 0,
                Inventory_Number = 0,
                Created_At = DateTime.UtcNow,
                Updated_At = DateTime.UtcNow
            }
        };

        modelBuilder.Entity<Inventory>().HasData(inventory);
    }
}
