using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.Inventories.interfaces;

public interface IViewInventoriesByNameUseCase
{
   Task<IEnumerable<Inventory>> ExecuteAsnc(string name = "");
}