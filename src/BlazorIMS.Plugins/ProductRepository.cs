using System;
using System.Net;
using BlazorIMS.CoreBusiness;
using BlazorIMS.UseCases.PluginsInterfaces;
using Microsoft.VisualBasic;

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
        if(product is null) return Task.CompletedTask;

        if(_products is null || _products.Count<1)
        {
            product.ProductId = 1;
        }
        else
        {
            var maxId = _products.Max(p => p.ProductId);
            product.ProductId = maxId + 1;
        }
        _products.Add(product);
        return Task.CompletedTask;
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

    public async Task<Product> GetProductsByIdAsync(int id)
    {
        var product = _products?.FirstOrDefault(p => p.ProductId == id);
        Product? newprod = null;
        if(product is not null)
        {
            newprod = new Product()
            {
              ProductId = product.ProductId,
              ProductName = product.ProductName, 
              Quantity = product.Quantity,
              Price = product.Price,
              productInventories = new List<ProductInventory>()
            };
            if(product.productInventories is not null || product.productInventories.Count > 0)
            {
               foreach(var productInventory in product.productInventories)
               {
                  ProductInventory newProductInventory = new ProductInventory()
                  {
                    Product = productInventory.Product, 
                    ProductId = productInventory.ProductId, 
                    InventoryId = productInventory.InventoryId, 
                    InventoryQuantity = productInventory.InventoryQuantity, 
                    Inventory = new Inventory()
                  };
                  if(productInventory.Inventory is not null)
                  {
                    newProductInventory.Inventory.InventoryId = productInventory.Inventory.InventoryId;   
                    newProductInventory.Inventory.InventoryName = productInventory.Inventory.InventoryName;      
                    newProductInventory.Inventory.Quantity = productInventory.Inventory.Quantity;      
                    newProductInventory.Inventory.Price = productInventory.Inventory.Price;         
                  }
                  newprod.productInventories.Add(newProductInventory);
               }      
            }
        }
        return await Task.FromResult(newprod);
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
        if(_products.Any(p => p.ProductId != product.ProductId &&
        p.ProductName.ToLower().Equals(product.ProductName.ToLower(), StringComparison.OrdinalIgnoreCase)))
          return Task.CompletedTask;
        
        var productToUpdate = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
        if(productToUpdate is not null)
        {
           productToUpdate.ProductName = product.ProductName;
           productToUpdate.Quantity = product.Quantity;
           productToUpdate.Price = product.Price;
           productToUpdate.productInventories = product.productInventories;
        }
        return Task.CompletedTask;
    }
}
