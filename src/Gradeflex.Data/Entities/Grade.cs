namespace Gradeflex.Data.Entities;

public class Grade
{
    public int Id { get; set; }
    public int Value { get; set; }
    public GradeType Type { get; set; }

    public int CourseId { get; set; }
    public int StudentId { get; set; }
    public CourseStudent CourseStudent { get; set; }
}