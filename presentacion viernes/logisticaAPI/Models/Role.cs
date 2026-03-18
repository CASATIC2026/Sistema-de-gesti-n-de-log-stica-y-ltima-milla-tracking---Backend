namespace LogisticaAPI.Models;

public class Role
{
    public int RoleId { get; set; }
    public string Name { get; set; } = string.Empty;   // "Admin", "Driver", "Cliente"

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}