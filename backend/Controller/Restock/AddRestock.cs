// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using backend.Data;
// using backend.Models.LineItems;
// using LineItemModel = backend.Models.LineItems.RestockLineItems;
// using backend.Models.RestockModel;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using backend.Dtos.Restock;

// namespace backend.Controller.Restocks
// {
//     [ApiController]
//     [Route("api/restock/")]
//     public class AddRestock : ControllerBase
//     {
//         private readonly ApplicationDBContext _db;

//         public AddRestock(ApplicationDBContext db)
//         {
//             _db = db;
//         }

//         [HttpPost]
//         public async Task<IActionResult> Create([FromBody] RestockDTO[] payload)
//         {
//             if (payload == null || payload.Length == 0) return BadRequest("Payload required");

//             Console.WriteLine(payload);


//             var createdRestocks = new List<object>();

//             // Use a transaction so we don't partially create LineItem/Batch/Restock on error
//             await using var transaction = await _db.Database.BeginTransactionAsync();

//             foreach (var dto in payload)
//             {
//                 // Validate restock clerk exists (prevent FK constraint failure)
//                 if (!string.IsNullOrEmpty(dto.Restock_Clerk))
//                 {
//                     var clerkExists = await _db.Users.AnyAsync(u => u.Id == dto.Restock_Clerk);
//                     if (!clerkExists)
//                     {
//                         // rollback transaction and return a clear error
//                         await transaction.RollbackAsync();
//                         return BadRequest($"Restock clerk with id '{dto.Restock_Clerk}' not found.");
//                     }
//                 }
//                 var lineItem = new LineItemModel
//                 {
//                     Product_ID = dto.LineItem.Product_ID,
//                     Unit = dto.LineItem.Unit,
//                     Unit_Price = dto.LineItem.Unit_Price,
//                     Sub_Total = dto.LineItem.Sub_Total,
//                     Quantity = dto.LineItem.Quantity,
//                 };

//                 _db.Add(lineItem);
//                 await _db.SaveChangesAsync();

//                 var batch = new RestockBatch
//                 {
//                     Batch_Number = dto.Batch.Batch_Number,
//                     Supplier_ID = dto.Batch.Supplier_ID,
//                     CreatedAt = DateTime.UtcNow,
//                     UpdatedAt = DateTime.UtcNow,
//                 };

//                 _db.Add(batch);
//                 await _db.SaveChangesAsync();

//                 var restock = new Restock
//                 {
//                     Batch_ID = batch.Batch_ID,
//                     Restock_Clerk = dto.Restock_Clerk,
//                     Notes = dto.Notes,
//                     LineItems_Total = dto.LineItem.Quantity * dto.LineItem.Unit_Price
//                 };

//                 _db.Add(restock);
//                 await _db.SaveChangesAsync();

//                 createdRestocks.Add(new { restockId = restock.Restock_ID, lineItemId = lineItem.LineItem_ID, batchId = batch.Batch_ID });
//             }

//             // commit transaction
//             await transaction.CommitAsync();

//             return Ok(createdRestocks);
//         }
//     }
// }