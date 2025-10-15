using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.Inventory;

namespace backend.Models.LineItems
{
    public class LineItem
    {
        [Key]
        public int LineItem_ID { get; set; }

        // FKs
        public int Product_ID { get; set; }
        [ForeignKey(nameof(Product_ID))]
        public Product Product { get; set; } = null!;

        public string Unit { get; set; } = null!;
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }
        public int Quantity { get; set; }
    }
}