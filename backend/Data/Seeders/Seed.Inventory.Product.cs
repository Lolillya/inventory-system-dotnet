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
        var product = new List<Product>
        {
            new Product
            {
                Product_Id = 1,
                Product_Code = "",
                Product_Name = "",
                Description = "",
                Brand_Id = 1,
                Category_Id = 1,
                Variant_Id = 1,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        };

        modelBuilder.Entity<Product>().HasData(product);


    }
}
