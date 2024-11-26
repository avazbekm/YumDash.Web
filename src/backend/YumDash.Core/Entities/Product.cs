using YumDash.Domain.Common;

namespace YumDash.Domain.Entities;

public class Product:Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImagePath { get; set; }
    public int CategoryId { get; set; } // Foreign Key
    public Category Category { get; set; } // Navigation Property
    public bool IsActive { get; set; }
}

