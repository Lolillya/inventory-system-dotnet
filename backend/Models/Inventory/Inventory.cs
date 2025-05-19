using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace backend.Models.Inventory
{
    public class Inventory
    {
        public int Inventory_Id { get; set; }
        public int Variant_Id { get; set; }
        public BigInteger Total_Quantity { get; set; }
        public BigInteger Inventory_Number { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public string Inventory_Clerk { get; set; }
    }
}