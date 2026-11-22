using System;
using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.PluginsInterfaces;
using BlazorIMS.UseCases.Activity.Interfaces;

namespace BlazorIMS.UseCases.Activity;

public class PurchaseInventoryUseCase : IPurchaseInventoryUseCase
{
    private readonly IInventoryTransactionRepository inventoryTransactionRepository;
    private readonly IInventoryRepository inventoryRepository;
    public PurchaseInventoryUseCase(IInventoryTransactionRepository inventoryTransactionRepository, IInventoryRepository inventoryRepository)
    {
        this.inventoryTransactionRepository = inventoryTransactionRepository;
        this.inventoryRepository = inventoryRepository;
    }

    public async Task ExecuteAsync(string poNumber, Inventory inventory, int quantity, string DoneBy)
    {
        await inventoryTransactionRepository.PurchaseAsync(poNumber, inventory, quantity, DoneBy, inventory.Price);
        inventory.Quantity += quantity;
        await inventoryRepository.UpdateInventoryAsync(inventory);
    }
}
