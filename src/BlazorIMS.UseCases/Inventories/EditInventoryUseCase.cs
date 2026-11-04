using System;
using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.PluginsInterfaces;

namespace BlazorIMS.UseCases.Inventories.interfaces;

public class EditInventoryUseCase : IEditInventoryUseCase
{
    private readonly IInventoryRepository? inventoryRepository;

    public EditInventoryUseCase(IInventoryRepository inventoryRepository)
    {
        this.inventoryRepository = inventoryRepository;
    }

    public async Task ExecuteAsync(Inventory inventory)
    {
        await inventoryRepository.UpdateInventoryAsync(inventory);
    }
}
