using System;
using System.ComponentModel.DataAnnotations;

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
}

