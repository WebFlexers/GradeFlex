namespace Gradeflex.Data.Entities;

public class CourseStudent
{
    public int CourseId { get; set; }
    public int StudentId { get; set; }

    public Course Course { get; set; }
    public Student Student { get; set; }
    //public List<Grade> Grades { get; set; }
}
