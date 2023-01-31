namespace Gradeflex.Models.Professor;

public class StudentGradesViewModel
{
    public int RegistrationNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<GradeViewModel> Grades { get; set; }
    public double FinalGrade { get; set; }
}
