using System.Text.Json;
using backend.Data;
using backend.Models.RestockModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Dtos.RestockModel;
using backend.Dtos.LineItem;

namespace backend.Controller.RestockControllers
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

            Console.WriteLine("Create payload: {0}", JsonSerializer.Serialize(payload));


            var createdRestocks = new List<object>();
            var createdRestockIds = new List<int>();
            // Use a transaction so we don't partially create LineItem/Batch/Restock on error
            await using var transaction = await _db.Database.BeginTransactionAsync();

            foreach (var dto in payload)
            {
                // Validate restock clerk exists (prevent FK constraint failure)
                if (!string.IsNullOrEmpty(dto.Restock_Clerk))
                {
                    var clerkExists = await _db.Users.AnyAsync(u => u.Id == dto.Restock_Clerk);
                    if (!clerkExists)
                    {
                        // rollback transaction and return a clear error
                        await transaction.RollbackAsync();
                        return BadRequest($"Restock clerk with id '{dto.Restock_Clerk}' not found.");
                    }
                }

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
                    Batch_ID = batch.Batch_ID,
                    Restock_Clerk = dto.Restock_Clerk,
                    Notes = dto.Notes,
                    LineItems_Total = dto.LineItem.Quantity * dto.LineItem.Unit_Price
                };

                _db.Add(restock);
                await _db.SaveChangesAsync();

                createdRestocks.Add(new { restockId = restock.Restock_ID, batchId = batch.Batch_ID });
                createdRestockIds.Add(restock.Restock_ID);
            }

            // commit transaction (commit after line items are created)
            await transaction.CommitAsync();
            // create line items, passing the created restock ids in the same order
            await CreateLineItems(payload, createdRestockIds.ToArray());


            return Ok(createdRestocks);
        }
        private async Task CreateLineItems(RestockDTO[] payload, int[] restockIds)
        {
            var createdLineItems = new List<object>();

            // Serialize the payload and the associated restock IDs so the console shows detailed contents
            Console.WriteLine("CreateLineItems payload: {0}", JsonSerializer.Serialize(payload));
            Console.WriteLine("Associated restockIds: {0}", JsonSerializer.Serialize(restockIds));

            for (int i = 0; i < payload.Length; i++)
            {
                var dto = payload[i];
                var restockId = restockIds.Length > i ? restockIds[i] : 0;

                var lineItem = new backend.Models.LineItems.RestockLineItems
                {
                    Product_ID = dto.LineItem.Product_ID,
                    Restock_ID = restockId,
                    Unit = dto.LineItem.Unit,
                    Unit_Price = dto.LineItem.Unit_Price,
                    Sub_Total = dto.LineItem.Sub_Total,
                    Quantity = dto.LineItem.Quantity
                };

                Console.WriteLine(lineItem);

                _db.Add(lineItem);
                await _db.SaveChangesAsync();

                createdLineItems.Add(new { lineItemId = lineItem.LineItem_ID, restockId = restockId });
            }
        }
    }
}