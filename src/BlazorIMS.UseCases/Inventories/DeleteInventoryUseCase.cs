using System;
using BlazorIMS.UseCases.Inventories.interfaces;
using BlazorIMS.UseCases.PluginsInterfaces;

namespace BlazorIMS.UseCases.Inventories;

public class DeleteInventoryUseCase : IDeleteInventoryUseCase
{
    private readonly IInventoryRepository? inventoryRepository;

    public DeleteInventoryUseCase(IInventoryRepository inventoryRepository)
    {
        this.inventoryRepository = inventoryRepository;
    }

    public async Task ExecuteAsync(int inventoryId)
    {
        await inventoryRepository.DeleteInventoryAsync(inventoryId);
    }
}
