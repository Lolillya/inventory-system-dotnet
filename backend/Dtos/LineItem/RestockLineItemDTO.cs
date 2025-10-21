using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.LineItem
{
    public class RestockLineItemDto
    {
        [Required]
        public int Product_ID { get; set; }
        [Required]
        public int Restock_ID { get; set; }
        [Required]
        public string Unit { get; set; } = null!;
        [Required]
        public decimal Unit_Price { get; set; }
        [Required]
        public decimal Sub_Total { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}