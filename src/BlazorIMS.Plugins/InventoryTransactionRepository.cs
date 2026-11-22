using System;
using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.PluginsInterfaces;

namespace BlazorIMS.Plugins;

public class InventoryTransactionRepository : IInventoryTransactionRepository
{
    private List<InventoryTransaction> _inventoryTransactions = new List<InventoryTransaction>();
    public Task PurchaseAsync(string poNumber, Inventory inventory, int quantity, string doneBy, double unitPrice)
    {
        int maxId = 1;
        if(_inventoryTransactions.Count > 0)
        {
          maxId = _inventoryTransactions.Max(it => it.InventoryTransactionID) + 1;
        }

       _inventoryTransactions.Add(new InventoryTransaction
       {
           InventoryTransactionID = maxId, 
           InventoryId = inventory.InventoryId,
           InventoryTransactionType = InventoryTransactionType.InventoryPurchase,
           PONumber = poNumber,
           QuantityBefore = inventory.Quantity,
           QuantityAfter = inventory.Quantity + quantity,
           UnitPrice = unitPrice,
           TransactionDate = DateTime.Now,
           DoneBy = doneBy,
           Inventory = inventory
       });
       return Task.CompletedTask;
    }
}
