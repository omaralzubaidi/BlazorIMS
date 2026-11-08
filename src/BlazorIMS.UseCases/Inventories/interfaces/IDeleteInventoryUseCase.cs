using System;

namespace BlazorIMS.UseCases.Inventories.interfaces;

public interface IDeleteInventoryUseCase
{
    Task ExecuteAsync(int inventoryId);
}