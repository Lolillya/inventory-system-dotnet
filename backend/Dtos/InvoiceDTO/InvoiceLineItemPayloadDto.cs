using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using backend.Dtos.RestockModel;

namespace backend.Dtos.InvoiceDTO
{
    public class InvoiceLineItemPayloadDto
    {
        [Required]
        public ItemDetailDto item { get; set; } = null!;
        [Required]
        public decimal total { get; set; }
        [Required]
        public string unit { get; set; }
        [Required]
        public decimal unit_price { get; set; }
        [Required]
        public int unit_quantity { get; set; }
    }
}