using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using backend.Models;
using api.Dtos.Suppliers;

namespace backend.Controller.Suppliers
{
    [Route("api/get-all-suppliers")]
    [ApiController]
    public class GetAllSuppliers : ControllerBase
    {
        private readonly UserManager<PersonalDetails> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public GetAllSuppliers(UserManager<PersonalDetails> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                // Get the supplier role
                var supplierRole = await _roleManager.FindByNameAsync("Supplier");
                if (supplierRole == null)
                    return NotFound("Supplier role not found");

                // Get all users in the supplier role
                var supplierUsers = await _userManager.GetUsersInRoleAsync("Supplier");

                // Map to DTO
                var suppliers = supplierUsers.Select(user => new SuppliersDto
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    CompanyName = user.CompanyName,
                    Notes = user.Notes,
                    PhoneNumber = user.PhoneNumber
                }).ToList();

                return Ok(suppliers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}