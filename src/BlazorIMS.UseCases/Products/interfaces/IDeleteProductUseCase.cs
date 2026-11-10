using System;

namespace BlazorIMS.UseCases.Products.interfaces;

public interface IDeleteProductUseCase
{
    Task ExecuteAsync(int productId);
}