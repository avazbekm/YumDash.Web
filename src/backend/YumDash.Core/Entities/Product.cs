using YumDash.Domain.Common;

namespace YumDash.Domain.Entities;

public class Product:Auditable
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string ImagePath { get; set; } = string.Empty;
    public int CategoryId { get; set; } // Foreign Key
    public Category Category { get; set; } = default!;// Navigation Property
    public bool IsActive { get; set; }
}

