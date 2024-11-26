namespace YumDash.Domain.Entities;

public class Payment
{
    public int Id { get; set; }
    public int OrderId { get; set; } // Foreign Key
    public Order Order { get; set; } // Navigation Property
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; }
    public DateTime PaymentDate { get; set; }
    public string Status { get; set; }
}
