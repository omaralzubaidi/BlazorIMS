using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorIMS.CoreBusiness.Validations;

public class Product_EnsurePriceGreaterThanInventoriesCost : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var product = validationContext.ObjectInstance as Product;
        if(product is not null)
        {
           if(!ValidatePrice(product))
            {
                return new ValidationResult($"The product's price is less than inventories cost {TotalInventoriesCost(product).ToString("c")}!", 
                new List<string>(){validationContext.MemberName});
            }
        }
        return ValidationResult.Success;
    }

    private double TotalInventoriesCost(Product product)
    {
        if(product is null && product.productInventories is null) return 0;

        return product.productInventories.Sum(pi => pi.InventoryQuantity * pi.Inventory?.Price ?? 0);
    }

    private bool ValidatePrice(Product product)
    {
        if(product is null || 
           product.productInventories is null ||
           product.productInventories.Count <= 0) return true;
        
        if(TotalInventoriesCost(product) > product.Price) return false;

        return true;
    }
}
