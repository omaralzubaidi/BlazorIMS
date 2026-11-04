using System;
using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.Inventories.interfaces;
using BlazorIMS.UseCases.PluginsInterfaces;

namespace BlazorIMS.UseCases.Inventories;

public class AddInventoryUseCase : IAddInventoryUseCase
{
    private readonly IInventoryRepository inventoryRepository;
    public AddInventoryUseCase(IInventoryRepository inventoryRepository)
    {
        this.inventoryRepository = inventoryRepository;
    }

    public async Task ExecuteAsync(Inventory inventory)
    {
        await inventoryRepository.AddInventoryAsync(inventory);
    }

}
