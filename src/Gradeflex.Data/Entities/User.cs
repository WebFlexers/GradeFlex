namespace Gradeflex.Data.Entities;

public class User
{
    public int Id { get; set; }

    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }

    public Professor Professor { get; set; }
    public Secretary Secretary { get; set; }
    public Student Student { get; set; }
}
