using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.PluginsInterfaces;
using BlazorIMS.UseCases.Products.interfaces;

namespace BlazorIMS.UseCases.Products;

public class EditProductUseCase : IEditProductUseCase
{
    private readonly IProductRepository productRepository;

    public EditProductUseCase(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    public async Task ExecuteAsync(Product product)
    {
        await productRepository.UpdateProductAsync(product);
    }
}
