using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.Products.interfaces;

public interface IEditProductUseCase
{
    Task ExecuteAsync(Product product);
}
