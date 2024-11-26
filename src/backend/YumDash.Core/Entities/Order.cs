using YumDash.Domain.Common;
using YumDash.Domain.Enums;

namespace YumDash.Domain.Entities;

public class Order : Auditable
{
    public int UserId { get; set; } // Foreign Key
    public User User { get; set; } = default!;// Navigation Property
    public decimal TotalAmount { get; set; }
    public Status PaymentStatus { get; set; } // Enum-like value
}
