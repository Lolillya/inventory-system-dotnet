using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.Seeders;
public class Roles
{
    public static void SeedRoles(ModelBuilder builder)
    {
        var roles = new List<IdentityRole>
        {
            new IdentityRole
            {
                Id = "1",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = "2",
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            },
            new IdentityRole
            {
                Id = "3",
                Name = "Supplier",
                NormalizedName = "SUPPLIER"
            },
            new IdentityRole
            {
                Id = "4",
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            }
        };

        builder.Entity<IdentityRole>().HasData(roles);
    }
}
