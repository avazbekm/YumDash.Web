using YumDash.Domain.Common;

namespace YumDash.Domain.Entities;

public class InventoryItem : Auditable
{
    public int ProductId { get; set; } // Foreign Key
    public Product Product { get; set; } // Navigation Property
    public string ProductCode { get; set; }
    public int Quantity { get; set; }
    public string UnitOfMeasure { get; set; }
    public int MinStockLevel { get; set; }
    public int WarehouseId { get; set; } // Foreign Key
    public Warehouse Warehouse { get; set; } // Navigation Property
}
