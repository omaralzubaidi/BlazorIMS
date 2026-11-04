using System;
using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.Inventories.interfaces;
using BlazorIMS.UseCases.PluginsInterfaces;


namespace BlazorIMS.UseCases.Inventories;

public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
{
    private readonly IInventoryRepository InventoryRepository;

    public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
    {
        InventoryRepository = inventoryRepository;
    }
    public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
    {
       return await InventoryRepository.GetInventoriesByNameAsync(name);
    }
}


