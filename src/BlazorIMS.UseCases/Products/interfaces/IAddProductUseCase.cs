using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.Products.interfaces;

public interface IAddProductUseCase
{
    Task ExecuteAsync(Product product);
}