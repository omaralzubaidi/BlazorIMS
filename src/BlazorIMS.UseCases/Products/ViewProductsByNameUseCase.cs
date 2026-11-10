using System;
using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.Inventories.interfaces;
using BlazorIMS.UseCases.PluginsInterfaces;
using BlazorIMS.UseCases.Products.interfaces;


namespace BlazorIMS.UseCases.Products;



public class ViewProductsByNameUseCase : IViewProductsByNameUseCase
{
    private readonly IProductRepository productRepository;

    public ViewProductsByNameUseCase(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }
    public async Task<IEnumerable<Product>> ExecuteAsync(string name = "")
    {
        return await productRepository.GetProductsByNameAsync(name);
    }

}


