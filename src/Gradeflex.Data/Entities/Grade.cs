namespace Gradeflex.Data.Entities;

public class Grade
{
    public int Id { get; set; }
    public double Value { get; set; }
    public GradeType Type { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }
}