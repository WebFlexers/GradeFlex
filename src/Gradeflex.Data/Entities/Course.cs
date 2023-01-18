namespace Gradeflex.Data.Entities;

public class Course
{
    public int Id { get; set; }

    public string Title { get; set; }
    public string Semester { get; set; }
    public HashSet<CourseStudent> CoursesStudents { get; set; }

    public int ProfessorId { get; set; }
    public Professor Professor { get; set; }
}
