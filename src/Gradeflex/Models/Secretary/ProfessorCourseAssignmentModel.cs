using System.ComponentModel.DataAnnotations;

namespace Gradeflex.Models.Secretary;

public class ProfessorCourseAssignmentModel
{
    [Required]
    public int CourseId { get; set; }
    [Required]
    [RegularExpression(@"^\d{9}$", ErrorMessage = "The value must be exactly 9 digits")]
    [Display(Name = "Professor Afm")]
    public int Afm { get; set; }
    [Required]
    [StringLength(45, MinimumLength = 5)]
    public string Department { get; set; }
}
