using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.PluginsInterfaces;

public interface IInventoryTransactionRepository
{
    Task PurchaseAsync(string pONumber, Inventory inventory, int quantity, string doneBy, double unitPrice);
}
