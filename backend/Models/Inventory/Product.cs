using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Inventory
{
    public class Product
    {
        public int Product_Id { get; set; }
        public string Product_Code { get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public int Brand_Id { get; set; }
        public int Category_Id { get; set; }
        public int Variant_Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}