namespace Gradeflex.Data.Entities;

public class Secretary
{
    public int PhoneNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Department { get; set; }

    public User User { get; set; }
}
