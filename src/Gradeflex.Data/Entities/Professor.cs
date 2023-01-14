namespace Gradeflex.Data.Entities;

public class Professor
{
    public int Id { get; set; }

    public int Afm { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Department { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}
