using YumDash.Domain.Common;

namespace YumDash.Domain.Entities;

public class Role:Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
}

