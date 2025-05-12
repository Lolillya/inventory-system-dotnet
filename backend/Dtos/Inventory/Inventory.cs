using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace backend.Dtos.Inventory
{
    public class Inventory
    {
        [Required]
        public BigInteger TotalQuantity { get; set; }
        [Required]
        public BigInteger InventoryNumber { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

    }
}