namespace YumDash.Domain.Entities;

public class InventoryTransaction
{
    public int Id { get; set; }
    public int InventoryItemId { get; set; } // Foreign Key
    public InventoryItem InventoryItem { get; set; } // Navigation Property
    public DateTime TransactionDate { get; set; }
    public decimal QuantityChanged { get; set; }
    public string TransactionType { get; set; } // Add, Remove, etc.
}
