using System.ComponentModel.DataAnnotations;

namespace Gradeflex.Models.Secretary;

public class StudentCourseDeclarationModel
{
    [Required]
    public int CourseId { get; set; }
    [Required]
    [RegularExpression(@"^\d{5}$", ErrorMessage = "The value must be exactly 5 digits")]
    [Display (Name = "Student Registration Number")]
    public string RegistrationNumber { get; set; }
    [Required]
    [StringLength(45, MinimumLength = 5)]
    public string Department { get; set; }
}
