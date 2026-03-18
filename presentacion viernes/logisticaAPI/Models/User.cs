namespace LogisticaAPI.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public bool IsActive { get; set; }

    public int RoleId { get; set; }
    public virtual Role Role { get; set; } = null!;

    public List<Order> Orders { get; set; }
}