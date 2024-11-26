using YumDash.Domain.Common;

namespace YumDash.Domain.Entities;

public class Order : Auditable
{
    public int UserId { get; set; } // Foreign Key
    public User User { get; set; } // Navigation Property
    public decimal TotalAmount { get; set; }
    public string PaymentStatus { get; set; } // Enum-like value
}
