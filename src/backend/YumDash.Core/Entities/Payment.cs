using YumDash.Domain.Enums;

namespace YumDash.Domain.Entities;

public class Payment
{
    public int Id { get; set; }
    public int OrderId { get; set; } // Foreign Key
    public Order Order { get; set; } = default!; // Navigation Property
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;
    public DateTime PaymentDate { get; set; }
    public Status Status { get; set; }
}
