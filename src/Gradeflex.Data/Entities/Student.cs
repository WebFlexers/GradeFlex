namespace Gradeflex.Data.Entities;

public class Student
{
    public int Id { get; set; }

    public int RegistrationNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Department { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
