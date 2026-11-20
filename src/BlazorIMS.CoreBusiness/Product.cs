using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using BlazorIMS.Plugins;
using BlazorIMS.CoreBusiness.Validations;

namespace BlazorIMS.CoreBusiness;

public class Product
{
   public int ProductId{get; set;}

   [Required]
   [StringLength(17)]
   public string ProductName{get; set;} = string.Empty;

   [Range(0, 1000000, ErrorMessage = "Quantity must be greator or equal to 0")]
   public int Quantity{get; set;}
   
   [Range(0, 1000000, ErrorMessage = "Price must be greator or equal to 0")]
   public double Price{get; set;}

   [Product_EnsurePriceGreaterThanInventoriesCost]
   public List<ProductInventories> productInventories {get; set;} = new List<ProductInventories>();

   public void AddInventory(Inventory inventory)
   {
      if(!productInventories.Any(pi=> pi.Inventory is not null && pi.Inventory.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
      {
         productInventories.Add(new ProductInventories
         {
            ProductId = this.ProductId,
            Product = this,
            Inventory = inventory, 
            InventoryId = inventory.InventoryId, 
            InventoryQuantity = 1
         }
         );
         
      }
   }

   public void RemoveInventory(ProductInventories productInventories)
   {
      this.productInventories.Remove(productInventories);
   }
}

