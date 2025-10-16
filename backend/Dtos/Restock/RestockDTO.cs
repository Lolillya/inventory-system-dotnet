using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.LineItem;

namespace backend.Dtos.Restock
{
    public class RestockDTO
    {
        public LineItemDto LineItem { get; set; } = null!;
        public RestockBatchDto Batch { get; set; } = null!;
        public string Restock_Clerk { get; set; } = "";
        public string Notes { get; set; } = "";
    }
}