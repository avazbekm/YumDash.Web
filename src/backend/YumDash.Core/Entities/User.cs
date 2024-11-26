using YumDash.Domain.Common;

namespace YumDash.Domain.Entities;

public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public int RoleId { get; set; } // Foreign Key
    public Role Role { get; set; } // Navigation Property
    public string Phone { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }
}