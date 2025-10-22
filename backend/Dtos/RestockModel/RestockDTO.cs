using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using backend.Dtos.LineItem;

namespace backend.Dtos.RestockModel
{
    public class RestockDTO
    {
        // Now accepts an array of line items matching the frontend payload
        [Required]
        public List<RestockLineItemPayloadDto> LineItem { get; set; } = new List<RestockLineItemPayloadDto>();

        [Required]
        public RestockBatchDto Batch { get; set; } = null!;

        public string Restock_Clerk { get; set; } = "";

        public string Notes { get; set; } = "";
    }
}