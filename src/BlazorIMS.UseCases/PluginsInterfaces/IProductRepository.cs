using System;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.UseCases.PluginsInterfaces;

public interface IProductRepository
{
    Task AddProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task<Product> GetProductsByIdAsync(int id);
    Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
    Task DeleteProductAsync(int productId);
}
