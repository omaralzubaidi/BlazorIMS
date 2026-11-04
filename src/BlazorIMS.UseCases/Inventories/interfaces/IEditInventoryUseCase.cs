using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.Inventories.interfaces;

public interface IEditInventoryUseCase
{
    Task ExecuteAsync(Inventory inventory);
}
