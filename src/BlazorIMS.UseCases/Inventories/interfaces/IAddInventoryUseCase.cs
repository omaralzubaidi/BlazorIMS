using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.Inventories.interfaces;

public interface IAddInventoryUseCase
{
    Task ExecuteAsync(Inventory inventory);
}