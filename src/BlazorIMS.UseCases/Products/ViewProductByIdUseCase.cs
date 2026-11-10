using System;
using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.Inventories.interfaces;
using BlazorIMS.UseCases.PluginsInterfaces;
using BlazorIMS.UseCases.Products.interfaces;

namespace BlazorIMS.UseCases.Products;

public class ViewProductByIdUseCase : IViewProductByIdUseCase
{
    private readonly IProductRepository productRepository;

    public ViewProductByIdUseCase(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    public async Task<Product> ExecuteAsync(int id)
    {
        return await productRepository.GetProductsByIdAsync(id);
    }

}
