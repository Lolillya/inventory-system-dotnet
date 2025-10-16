using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Restock
{
    public class RestockBatchDto
    {
        public int Batch_Number { get; set; }
        public string Supplier_ID { get; set; } = "";
    }
}