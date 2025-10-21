using System.ComponentModel.DataAnnotations;
using backend.Dtos.LineItem;

namespace backend.Dtos.RestockModel
{
    public class RestockDTO
    {
        [Required]
        public LineItemDto LineItem { get; set; } = null!;

        [Required]
        public RestockBatchDto Batch { get; set; } = null!;

        public string Restock_Clerk { get; set; } = "";

        public string Notes { get; set; } = "";
    }
}