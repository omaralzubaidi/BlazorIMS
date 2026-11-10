using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.Products.interfaces;

public interface IViewProductsByNameUseCase
{
   Task<IEnumerable<Product>> ExecuteAsync(string name = "");
}