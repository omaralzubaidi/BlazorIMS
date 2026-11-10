using System;
using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.PluginsInterfaces;

namespace BlazorIMS.Plugins;

public class ProductRepository : IProductRepository
{ 
    private List<Product>? _products;

    public ProductRepository()
    {
      _products = new List<Product>()
      {
        new Product{ProductId = 1, ProductName = "Bike", Quantity = 7, Price = 13},
        new Product{ProductId = 2, ProductName = "Car", Quantity = 17, Price = 137},
        new Product{ProductId = 3, ProductName = "Wheellchair", Quantity = 87, Price = 138},
        new Product{ProductId = 4, ProductName = "motorcycle", Quantity = 97, Price = 139},

      };
    }
    public Task AddProductAsync(Product product)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteProductAsync(int productId)
    {
        var productToDelete = _products.FirstOrDefault(p => p.ProductId == productId);
        if(productToDelete is not null)
        {
            _products.Remove(productToDelete);
        }
        await Task.CompletedTask;
    }

    public Task<Product> GetProductsByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetProductsByNameAsync(string name)
    {
        if(string.IsNullOrEmpty(name))
        {
          return await Task.FromResult(_products??new List<Product>());    
        }
        return _products.Where(p => p.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase));
    }

    public Task UpdateProductAsync(Product product)
    {
        throw new NotImplementedException();
    }
}
