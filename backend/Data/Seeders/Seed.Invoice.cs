using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.Models.Invoice;

namespace backend.Data.Seeders;

public static class SeedInvoice
{
    public static void SeedInvoiceData(ModelBuilder builder)
    {


        var seededAt = new DateTime(2025, 01, 01, 00, 00, 00, DateTimeKind.Utc);

        var invoices = new List<Invoice>
        {
            new Invoice
            {
                Invoice_ID = 1,
                Invoice_Number = 1,
                Notes = "Sample Invoice Note",
                // reference existing seeded users from AspNetUsers (see SeedUsersV2 migration)
                Customer_ID = "4",
                Invoice_Clerk = "2",
                // Navigation properties must not be set when using HasData (EF requires scalar FK values only)
                CreatedAt = seededAt,
                UpdatedAt = seededAt,
                Total_Amount = 99999.00m,
                Discount = 0.00m,
                Status = "Sample Invoice Status",
                Term = 30,
            }
        };

        // Pass the array of invoices to HasData
        builder.Entity<Invoice>().HasData(invoices.ToArray());
    }
}
