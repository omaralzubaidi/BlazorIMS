using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.Inventories.interfaces;

public interface IViewInventoryByIdUseCase
{
    Task<Inventory> ExecuteAsync(int id);
}
