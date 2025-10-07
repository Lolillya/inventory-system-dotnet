using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Invoice
{
    public class Invoice
    {
        [Key]
        public int Invoice_ID { get; set; }
        public int Invoice_Number { get; set; }
        public string? Notes { get; set; }
        public int Customer_ID { get; set; }
        public int Invoice_Clerk { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public float Total_Amount { get; set; }
        public float Discount { get; set; }
        public string? Status { get; set; }
        public int Term { get; set; }
    }
}