using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace backend.Data.Seeders;

public static class Suppliers
{
    public static void SeedSupplierUsers(ModelBuilder modelBuilder)
    {
        var suppliers = new List<PersonalDetails>
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
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1
            },
            new PersonalDetails
            {
                Id = "56e2e671-7353-4bce-950b-b76d74915f0f",
                UserName = "alphaworks",
                NormalizedUserName = "ALPHAWORKS",
                Email = "sales@alphaworks.com",
                NormalizedEmail = "SALES@ALPHAWORKS.COM",
                EmailConfirmed = true,
                FirstName = "Emily",
                LastName = "Stewart",
                CompanyName = "AlphaWorks Stationers",
                Notes = "Office supplies distributor",
                PhoneNumber = "3456789007",
                SecurityStamp = "666a4160-19a6-430d-896b-9edd6f61a21c",
                ConcurrencyStamp = "1b867235-a6e7-4c6b-8418-e66546026902",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "5cc99ded-fe07-4bbb-a761-4a6025891f9f",
                UserName = "brightbooks",
                NormalizedUserName = "BRIGHTBOOKS",
                Email = "info@brightbooks.com",
                NormalizedEmail = "INFO@BRIGHTBOOKS.COM",
                EmailConfirmed = true,
                FirstName = "Jason",
                LastName = "Lee",
                CompanyName = "BrightBooks Inc.",
                Notes = "Book and educational materials supplier",
                PhoneNumber = "3456789008",
                SecurityStamp = "cc8a4155-0a2e-45b9-8cd1-8627269b3ba5",
                ConcurrencyStamp = "cc8a4155-0a2e-45b9-8cd1-8627269b3ba5",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "2813ffb1-e876-4183-9621-480f02708712",
                UserName = "colorcopy",
                NormalizedUserName = "COLORCOPY",
                Email = "hello@colorcopy.com",
                NormalizedEmail = "HELLO@COLORCOPY.COM",
                EmailConfirmed = true,
                FirstName = "Sophia",
                LastName = "Carter",
                CompanyName = "ColorCopy Ltd.",
                Notes = "Printing and copying supplies",
                PhoneNumber = "3456789009",
                SecurityStamp = "a439dd21-ceec-4f99-9600-6829b8211f9b",
                ConcurrencyStamp = "41b5702a-632f-4524-adc3-622b161713f6",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "f542b6c8-24f1-4dbe-8a1c-05866a020016",
                UserName = "nextgenoffice",
                NormalizedUserName = "NEXTGENOFFICE",
                Email = "contact@nextgenoffice.com",
                NormalizedEmail = "CONTACT@NEXTGENOFFICE.COM",
                EmailConfirmed = true,
                FirstName = "Ryan",
                LastName = "Turner",
                CompanyName = "NextGen Office Equipment",
                Notes = "Office equipment and supplies",
                PhoneNumber = "3456789010",
                SecurityStamp = "016609ef-88be-4c47-be8f-d417310834f0",
                ConcurrencyStamp = "0b6683fb-059b-47f4-9457-41343c974d95",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "31f025f2-60a3-4a15-8b3d-5e929e1f12f4",
                UserName = "smartstationers",
                NormalizedUserName = "SMARTSTATIONERS",
                Email = "info@smartstationers.com",
                NormalizedEmail = "INFO@SMARTSTATIONERS.COM",
                EmailConfirmed = true,
                FirstName = "Hannah",
                LastName = "King",
                CompanyName = "SmartStationers Co.",
                Notes = "Stationery and office supplies",
                PhoneNumber = "3456789011",
                SecurityStamp = "da111342-cb10-48c8-80f2-3370f3468e43",
                ConcurrencyStamp = "9bd94843-af22-4be5-b7c1-0795c89f8c6d",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "eba6a85d-944e-42af-b963-1a22b2c66bfc",
                UserName = "offixsolutions",
                NormalizedUserName = "OFFIXSOLUTIONS",
                Email = "support@offixsolutions.com",
                NormalizedEmail = "SUPPORT@OFFIXSOLUTIONS.COM",
                EmailConfirmed = true,
                FirstName = "Jacob",
                LastName = "Moore",
                CompanyName = "Offix Solutions",
                Notes = "Office solutions provider",
                PhoneNumber = "3456789012",
                SecurityStamp = "d777e1f8-9893-48f4-8d00-93300ba89ad2",
                ConcurrencyStamp = "9cc56f99-01cf-442a-b397-93314ca67483",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "acef761f-019a-4ca2-982a-d8e7dee767ed",
                UserName = "primoeducational",
                NormalizedUserName = "PRIMOEDUCATIONAL",
                Email = "orders@primoeducational.com",
                NormalizedEmail = "ORDERS@PRIMOEDUCATIONAL.COM",
                EmailConfirmed = true,
                FirstName = "Ava",
                LastName = "White",
                CompanyName = "Primo Educational Supplies",
                Notes = "Educational supplies distributor",
                PhoneNumber = "3456789013",
                SecurityStamp = "a56c84c8-2d13-4243-8e53-9cb37ecdf9a8",
                ConcurrencyStamp = "9d9977ed-ea32-4ab2-832b-0b70dd82e5a6",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "e4f938e4-e3fc-4fe3-94d4-4a664de76e0d",
                UserName = "ecopaperplus",
                NormalizedUserName = "ECOPAPERPLUS",
                Email = "eco@ecopaperplus.com",
                NormalizedEmail = "ECO@ECOPAPERPLUS.COM",
                EmailConfirmed = true,
                FirstName = "Mia",
                LastName = "Hill",
                CompanyName = "EcoPaper Plus",
                Notes = "Eco-friendly paper products",
                PhoneNumber = "3456789014",
                SecurityStamp = "9bb73ee2-e28f-4711-9042-c9c1c29980d4",
                ConcurrencyStamp = "ef2f7100-d8b9-4e69-a8a3-7a449275eca6",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "fd9249ce-169c-457f-8513-7ada0ac1683b",
                UserName = "edusmart",
                NormalizedUserName = "EDUSMART",
                Email = "hello@edusmart.com",
                NormalizedEmail = "HELLO@EDUSMART.COM",
                EmailConfirmed = true,
                FirstName = "Noah",
                LastName = "Adams",
                CompanyName = "EduSmart Stationery",
                Notes = "Educational stationery supplier",
                PhoneNumber = "3456789015",
                SecurityStamp = "be7551f4-6ea9-40cc-b337-1c2c6db91faf",
                ConcurrencyStamp = "bb9a82b4-064d-4a1c-92b6-3982f074afcb",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "be61d1f3-dfc4-4c60-bbc2-0136ae5cfb5c",
                UserName = "brighttech",
                NormalizedUserName = "BRIGHTTECH",
                Email = "sales@brighttech.com",
                NormalizedEmail = "SALES@BRIGHTTECH.COM",
                EmailConfirmed = true,
                FirstName = "William",
                LastName = "Scott",
                CompanyName = "BrightTech Office Supplies",
                Notes = "Office technology and supplies",
                PhoneNumber = "3456789016",
                SecurityStamp = "818c6e97-8d4b-47a6-a61c-6cf55fd61312",
                ConcurrencyStamp = "2b963347-0568-4532-ba63-bff4d948f7b0",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "64bc2df7-a283-40c6-aa76-cc79d5d2378a",
                UserName = "primepapers",
                NormalizedUserName = "PRIMEPAPERS",
                Email = "orders@primepapers.com",
                NormalizedEmail = "ORDERS@PRIMEPAPERS.COM",
                EmailConfirmed = true,
                FirstName = "Isabella",
                LastName = "Green",
                CompanyName = "Prime Papers Corporation",
                Notes = "Paper products supplier",
                PhoneNumber = "3456789017",
                SecurityStamp = "56358e25-aa23-4266-8a1a-c38a81e799e7",
                ConcurrencyStamp = "6aab628a-68f4-4e7e-95a3-03c42897f849",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "e1615701-0602-4f0b-8815-c486c5e5fde0",
                UserName = "xpressstationery",
                NormalizedUserName = "XPRESSSTATIONERY",
                Email = "support@xpressstationery.com",
                NormalizedEmail = "SUPPORT@XPRESSSTATIONERY.COM",
                EmailConfirmed = true,
                FirstName = "James",
                LastName = "Wright",
                CompanyName = "Xpress Stationery Services",
                Notes = "Fast delivery stationery service",
                PhoneNumber = "3456789018",
                SecurityStamp = "e165ed1d-714e-4ebb-b81d-5823294e1934",
                ConcurrencyStamp = "a6c7ada1-0576-48f0-a02f-5e6a625da32b",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "4b33af44-e3f4-449c-becf-76dcc3b0f110",
                UserName = "globaloffices",
                NormalizedUserName = "GLOBALOFFICES",
                Email = "info@globaloffices.com",
                NormalizedEmail = "INFO@GLOBALOFFICES.COM",
                EmailConfirmed = true,
                FirstName = "Charlotte",
                LastName = "Baker",
                CompanyName = "Global Offices Ltd.",
                Notes = "International office supplies",
                PhoneNumber = "3456789019",
                SecurityStamp = "90b34228-cd8a-44fd-8de7-09d18dd05f3e",
                ConcurrencyStamp = "a37c40a4-1e7b-44ad-a4d1-3a76917fd82e",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            },
            new PersonalDetails
            {
                Id = "dd83701a-3664-44a0-b813-85d5e80532da",
                UserName = "aceoffice",
                NormalizedUserName = "ACEOFFICE",
                Email = "sales@aceoffice.com",
                NormalizedEmail = "SALES@ACEOFFICE.COM",
                EmailConfirmed = true,
                FirstName = "Lucas",
                LastName = "Mitchell",
                CompanyName = "AceOffice Supplies",
                Notes = "Premium office supplies",
                PhoneNumber = "3456789020",
                SecurityStamp = "083ec1d5-0395-4aed-86d4-4facf40f7b64",
                ConcurrencyStamp = "f56a3acc-f5e2-4dec-9d3c-62b6312f33cd",
                LockoutEnabled = true,
                TwoFactorEnabled = false,
                AccessFailedCount = 0,
                PasswordHash = "$2a$12$pfsAFvDl3XlZxfqBfXoNR.L98a6.83LIqb.pZrZQmB738RCG5Hm5C" //supplier1 
            }
        };

        modelBuilder.Entity<PersonalDetails>().HasData(suppliers);

        // Assign supplier role to all suppliers
        var userRoles = suppliers.Select(supplier =>
            new IdentityUserRole<string> { UserId = supplier.Id, RoleId = "3" }
        ).ToList();

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
    }
}
