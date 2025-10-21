using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Invoice
{
    public class Invoice
    {
        public int Invoice_ID { get; set; }
        [Required]
        public int Invoice_Number { get; set; }
        public string? Notes { get; set; }
        [Required]
        public int Customer_ID { get; set; }
        [Required]
        public int Invoice_Clerk { get; set; }
        [Required]
        public string Created_At { get; set; }
        [Required]
        public string Updated_At { get; set; }
        [Required]
        public float Total_Amount { get; set; }
        [Required]
        public float Discount { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Term { get; set; }


    }
}