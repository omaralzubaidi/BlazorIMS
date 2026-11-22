using System;

namespace BlazorIMS.CoreBusiness;

public class InventoryTransaction
{
    public int InventoryTransactionID{get; set;}
    public string PONumber{get; set;} = string.Empty;
    public int InventoryId{get; set;}
    public InventoryTransactionType InventoryTransactionType;
    public int QuantityBefore{get; set;}
    public DateTime TransactionDate{get; set;}
    public int QuantityAfter{get; set;}
    public double UnitPrice{get; set;}
    public string DoneBy{get; set;} = string.Empty;
    public Inventory? Inventory{get; set;}
}
