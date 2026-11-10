using System;
using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.Products.interfaces;
using BlazorIMS.UseCases.PluginsInterfaces;

namespace BlazorIMS.UseCases.Products;

public class AddProductUseCase : IAddProductUseCase
{
    private readonly IProductRepository productRepository;
    public AddProductUseCase(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    public async Task ExecuteAsync(Product product)
    {
        await productRepository.AddProductAsync(product);
    }

}
