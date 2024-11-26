using YumDash.Domain.Common;

namespace YumDash.Domain.Entities;

public class Warehouse : Auditable
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string ManagerName { get; set; }
    public ICollection<InventoryItem> InventoryItems { get; set; }
}
