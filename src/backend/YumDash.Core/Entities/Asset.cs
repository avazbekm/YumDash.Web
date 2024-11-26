using YumDash.Domain.Common;

namespace YumDash.Domain.Entities;

public class Asset : Auditable
{
    public string FileName { get; set; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
}