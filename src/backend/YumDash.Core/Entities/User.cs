using YumDash.Domain.Common;

namespace YumDash.Domain.Entities;

public class User : Auditable
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public int RoleId { get; set; } // Foreign Key
    public Role Role { get; set; } = default!;// Navigation Property
    public string Phone { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Salt { get; set; } = string.Empty;
}