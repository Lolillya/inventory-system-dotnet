using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace backend.Service
{
    public class InvoiceUserService
    {
        private readonly ApplicationDBContext _db;
        private readonly UserManager<PersonalDetails> _userManager;

        public InvoiceUserService(ApplicationDBContext db, UserManager<PersonalDetails> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task DeleteuserAndInvoiceAsync(string userId)
        {
            var invoices = await _db.Invoice
                .Where(i => i.Customer_ID == userId || i.Invoice_Clerk == userId)
                .ToListAsync();

            _db.Invoice.RemoveRange(invoices);
            await _db.SaveChangesAsync();

            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    throw new InvalidOperationException(
                        "Failed to delete user: " + string.Join("; ", result.Errors.Select(e => e.Description))
                    );
                }
            }
        }

        public async Task DeleteInvoiceAndMaybeUsersAsync(int invoiceId)
        {
            var invoice = await _db.Invoice.FindAsync(invoiceId);
            if (invoice == null) return;

            var customerId = invoice.Customer_ID;
            var clerkId = invoice.Invoice_Clerk;

            _db.Invoice.Remove(invoice);
            await _db.SaveChangesAsync();

            // Only delete a user if they have no other invoices
            async Task DeleteUserIfNoInvoicesAsync(string userId)
            {
                bool hasOther = await _db.Invoice.AnyAsync(i =>
                    i.Customer_ID == userId || i.Invoice_Clerk == userId);
                if (!hasOther)
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null) await _userManager.DeleteAsync(user);
                }
            }

            await DeleteUserIfNoInvoicesAsync(customerId);
            await DeleteUserIfNoInvoicesAsync(clerkId);
        }

    }
}