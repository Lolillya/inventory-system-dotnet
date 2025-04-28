using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using backend.Data;

namespace backend.Data
{
    public class ApplicationDBContext : IdentityDbContext<PersonalDetails>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed roles
            Seeders.Roles.SeedRoles(builder);

            // Seed users
            Seeders.Users.UserDataSeed(builder);
            Seeders.Suppliers.SeedSupplierUsers(builder);
        }
    }
}