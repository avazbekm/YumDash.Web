using YumDash.Domain.Common;

namespace YumDash.Domain.Entities;

public class OrderItem : Auditable
{
    public int OrderId { get; set; } // Foreign Key
    public Order Order { get; set; } = default!;// Navigation Property
    public int ProductId { get; set; } // Foreign Key
    public Product Product { get; set; } = default!; // Navigation Property
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
