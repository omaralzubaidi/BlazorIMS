using System;
using BlazorIMS.UseCases.PluginsInterfaces;
using BlazorIMS.UseCases.Products.interfaces;

namespace BlazorIMS.UseCases.Products;

public class DeleteProductUseCase : IDeleteProductUseCase
{
    private readonly IProductRepository? productRepository;

    public DeleteProductUseCase(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    public async Task ExecuteAsync(int productId)
    {
        await productRepository.DeleteProductAsync(productId);
    }
}
