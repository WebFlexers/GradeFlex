namespace Gradeflex.Models.Student;

public class CourseViewModel
{
    public string Title { get; set; }
    public string Semester { get; set; }
    public List<GradeViewModel> AllGrades { get; set; }
    public double FinalGrade { get; set; }
}
