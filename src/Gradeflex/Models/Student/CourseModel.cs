namespace Gradeflex.Models.Student;

public class CourseModel
{
    public string Title { get; set; }
    public string Semester { get; set; }
    public List<GradeModel> AllGrades { get; set; }
    public double FinalGrade { get; set; }
}
