using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.RestockModel
{
    public class RestockBatch
    {
        [Key]
        public int Batch_ID { get; set; }
        public int Batch_Number { get; set; }

        // FKs
        public string Supplier_ID { get; set; } = null!;

        [ForeignKey(nameof(Supplier_ID))]
        public PersonalDetails Supplier { get; set; } = null!;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}