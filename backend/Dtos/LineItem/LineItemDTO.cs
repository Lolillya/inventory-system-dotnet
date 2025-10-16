using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.LineItem
{
    public class LineItemDto
    {
        public int Product_ID { get; set; }
        public string Unit { get; set; } = "";
        public decimal Unit_Price { get; set; }
        public decimal Sub_Total { get; set; }
        public int Quantity { get; set; }
    }
}