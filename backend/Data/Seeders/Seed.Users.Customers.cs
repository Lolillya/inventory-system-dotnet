using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.Seeders;

public static class Customers
{
    public static void SeedCustomerUsers(ModelBuilder modelBuilder)
    {
        var customers = new List<PersonalDetails>
        {
            new PersonalDetails
            {
                Id = "a7f1f87f-8150-4c86-bef3-3b6f5b497c0b",
                UserName = "fastprint",
                NormalizedUserName = "FASTPRINT",
                Email = "support@fastprint.com",
                NormalizedEmail = "SUPPORT@FASTPRINT.COM",
                EmailConfirmed = true,
                FirstName = "Daniel",
                LastName = "Young",
                CompanyName = "FastPrint Solutions",
                Notes = "Printing and stationery supplier",
                PhoneNumber = "3456789006",
                SecurityStamp = "27f0738f-c40d-4766-be53-a6f42defc331",
                ConcurrencyStamp = "bb9bd41a-5582-49d2-be6e-3f576cefbbcb",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
            }

        };
        modelBuilder.Entity<PersonalDetails>().HasData(customers);

        // Assign customer role to all customers
        var userRoles = customers.Select(customer =>
            new IdentityUserRole<string> { UserId = customer.Id, RoleId = "4" }).ToList();


        modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

    }

}
