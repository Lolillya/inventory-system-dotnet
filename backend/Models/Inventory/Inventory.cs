using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace backend.Models.Inventory
{
    public class Inventory
    {
        public BigInteger TotalQuantity { get; set; }
        public BigInteger InventoryNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string InventoryClerk { get; set; }
    }
}