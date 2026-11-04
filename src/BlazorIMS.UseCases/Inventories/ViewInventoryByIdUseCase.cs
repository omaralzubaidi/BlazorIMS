using System;
using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.Inventories.interfaces;
using BlazorIMS.UseCases.PluginsInterfaces;

namespace BlazorIMS.UseCases.Inventories;

public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
{
    private readonly IInventoryRepository? inventoryRepository;

    public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository)
    {
        this.inventoryRepository = inventoryRepository;
    }

    public async Task<Inventory> ExecuteAsync(int id)
    {
        return await inventoryRepository.GetInventoriesByIdAsync(id);
    }
}
