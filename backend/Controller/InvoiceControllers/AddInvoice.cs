using System.Text.Json;
using backend.Data;
using backend.Dtos.InvoiceDTO;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controller.InvoiceControllers
{
    [ApiController]
    [Route("api/invoice/")]
    public class AddInvoice : ControllerBase
    {
        private readonly ApplicationDBContext _db;
        public AddInvoice(ApplicationDBContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] InvoiceDTO payload)
        {
            if (payload == null) return BadRequest("Payload Required!");

            Console.WriteLine("Create payload: {0}", JsonSerializer.Serialize(payload));

            return Ok();
        }
    }
}