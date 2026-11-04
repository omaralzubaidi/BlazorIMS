using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.PluginsInterfaces;

public interface IInventoryRepository
{
    Task AddInventoryAsync(Inventory inventory);
    Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
}
