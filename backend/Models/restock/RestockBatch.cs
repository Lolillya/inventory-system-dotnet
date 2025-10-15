using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.restock
{
    public class RestockBatch
    {
        [Key]
        public int Batch_ID { get; set; }
        public int Batch_Number { get; set; }

        // FKs
        public int Restock_ID { get; set; }
        public int Supplier_ID { get; set; }

        [ForeignKey(nameof(Supplier_ID))]
        public PersonalDetails Supplier { get; set; } = null!;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}