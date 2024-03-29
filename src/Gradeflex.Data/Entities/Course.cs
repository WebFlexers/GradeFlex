﻿namespace Gradeflex.Data.Entities;

public class Course
{
    public int Id { get; set; }

    public string Title { get; set; }
    public string Semester { get; set; }
    public string Department { get; set; }

    public HashSet<CourseStudent> CoursesStudents { get; set; }
    public HashSet<Grade> Grades { get; set; }

    public int? ProfessorId { get; set; }
    public Professor Professor { get; set; }
}
