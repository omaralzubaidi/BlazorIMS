using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.Activity.Interfaces;

public interface IPurchaseInventoryUseCase
{
    Task ExecuteAsync(string poNumber, Inventory inventory, int quantity, string DoneBy);
}
