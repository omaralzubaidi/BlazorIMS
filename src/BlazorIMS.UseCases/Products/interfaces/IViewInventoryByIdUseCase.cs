using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.Products.interfaces;

public interface IViewProductByIdUseCase
{
    Task<Product> ExecuteAsync(int productId);
}
