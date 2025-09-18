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
        var seededAt = new DateTime(2025, 01, 01, 00, 00, 00, DateTimeKind.Utc);
        var brands = new List<Brand>
        {
            new Brand
            {
                Brand_ID = 1,
                BrandName = "Pilot",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 2,
                BrandName = "Bic",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 3,
                BrandName = "Parker",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 4,
                BrandName = "Fiber Castel",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 5,
                BrandName = "Staedtler",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 6,
                BrandName = "Faber-Castell",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 7,
                BrandName = "Pentel",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 8,
                BrandName = "Sharpie",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 9,
                BrandName = "Expo",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 10,
                BrandName = "Crayola",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 11,
                BrandName = "Prismacolor",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 12,
                BrandName = "Moleskine",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 13,
                BrandName = "Oxford",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 14,
                BrandName = "Mead",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            },
            new Brand
            {
                Brand_ID = 15,
                BrandName = "Ticonderoga",
                CreatedAt = seededAt,
                UpdatedAt = seededAt
            }
        };

        modelBuilder.Entity<Brand>().HasData(brands);
    }
}
