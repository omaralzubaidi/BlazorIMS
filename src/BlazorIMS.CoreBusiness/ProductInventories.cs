using System;
using System.Security.Principal;
using System.Text.Json.Serialization;
using BlazorIMS.CoreBusiness;

namespace BlazorIMS.Plugins;

public class ProductInventories
{ 
   public int ProductId{get; set;}
   [JsonIgnore]
   public Product? Product{get; set;}
   public int InventoryId{get; set;}
   [JsonIgnore]
   public Inventory? Inventory{get; set;}
   public int InventoryQuantity{get; set;}
}
