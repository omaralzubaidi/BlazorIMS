using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.PluginsInterfaces;

public interface IInventoryRepository
{
    Task AddInventoryAsync(Inventory inventory);
    Task UpdateInventoryAsync(Inventory inventory);
    Task<Inventory> GetInventoriesByIdAsync(int id);
    Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
}
