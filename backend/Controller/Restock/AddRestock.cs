using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Models.LineItems;
using LineItemModel = backend.Models.LineItems.LineItem;
using backend.Models.restock;
using Microsoft.AspNetCore.Mvc;
using backend.Dtos.Restock;

namespace backend.Controller.Restocks
{
    [ApiController]
    [Route("api/restock/")]
    public class AddRestock : ControllerBase
    {
        private readonly ApplicationDBContext _db;

        public AddRestock(ApplicationDBContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RestockDTO[] payload)
        {
            if (payload == null || payload.Length == 0) return BadRequest("Payload required");

            Console.WriteLine(payload);


            var createdRestocks = new List<object>();

            foreach (var dto in payload)
            {
                var lineItem = new LineItemModel
                {
                    Product_ID = dto.LineItem.Product_ID,
                    Unit = dto.LineItem.Unit,
                    SubTotal = dto.LineItem.SubTotal,
                    Quantity = dto.LineItem.Quantity,
                };

                _db.Add(lineItem);
                await _db.SaveChangesAsync();

                var batch = new RestockBatch
                {
                    Batch_Number = dto.Batch.Batch_Number,
                    Supplier_ID = dto.Batch.Supplier_ID,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                _db.Add(batch);
                await _db.SaveChangesAsync();

                var restock = new Restock
                {
                    LineItem_ID = lineItem.LineItem_ID,
                    Batch_ID = batch.Batch_ID,
                    Restock_Clerk = dto.Restock_Clerk,
                    Notes = dto.Notes,
                };

                _db.Add(restock);
                await _db.SaveChangesAsync();

                createdRestocks.Add(new { restockId = restock.Restock_ID, lineItemId = lineItem.LineItem_ID, batchId = batch.Batch_ID });
            }

            return Ok(createdRestocks);
        }
    }
}