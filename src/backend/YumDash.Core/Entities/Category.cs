using YumDash.Domain.Common;

namespace YumDash.Domain.Entities;

public class Category:Auditable
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

