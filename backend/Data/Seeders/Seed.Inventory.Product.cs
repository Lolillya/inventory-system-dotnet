using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.Inventory;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.Seeders;

public class InventoryProduct
{
    public static void SeedProductData(ModelBuilder modelBuilder)
    {
        var seededAt = new DateTime(2025, 01, 01, 00, 00, 00, DateTimeKind.Utc);
        var product = new List<Product>
        {
            new Product
            {
                Product_ID = 1,
                Product_Code = "PILOT-G2-07-BLK",
                Product_Name = "Pilot G2 0.7 Gel Pen - Black",
                Description = "Smooth writing gel ink pen",
                Brand_ID = 1,
                Category_ID = 1,
                Variant_ID = 1,
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            }
        };

        modelBuilder.Entity<Product>().HasData(product);


    }
}
