using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.LineItems;

namespace backend.Models.restock
{
    public class Restock
    {
        [Key]
        public int Restock_ID { get; set; }

        // FKs
        public int LineItem_ID { get; set; }
        public int Batch_ID { get; set; }
        public string Restock_Clerk { get; set; } = null!;

        [ForeignKey(nameof(LineItem_ID))]
        public LineItem LineItem { get; set; } = null!;
        [ForeignKey(nameof(Restock_Clerk))]
        public PersonalDetails Clerk { get; set; } = null!;

        public string Notes { get; set; } = null!;
    }
}