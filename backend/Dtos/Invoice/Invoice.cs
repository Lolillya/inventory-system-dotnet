using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Invoice
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        [Required]
        public int InvoiceNumber { get; set; }
        public string? Notes { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int InvoiceClerk { get; set; }
        [Required]
        public string CreatedAt { get; set; }
        [Required]
        public string UpdatedAt { get; set; }
        [Required]
        public float TotalAmount { get; set; }
        [Required]
        public float Discount { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Term { get; set; }


    }
}