using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.PluginsInterfaces;

public interface IInventoryRepository
{
    Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
}
