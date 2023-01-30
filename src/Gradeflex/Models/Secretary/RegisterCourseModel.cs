using System.ComponentModel.DataAnnotations;

namespace Gradeflex.Models.Secretary;

public class RegisterCourseModel
{
    [Required]
    [StringLength(60, MinimumLength = 5)]
    [Display(Name = "Title")]
    public string Title { get; set; }

    [Required]
    [StringLength(25, MinimumLength = 1)]
    [Display(Name = "Semester")]
    public string Semester { get; set; }

    [Required]
    [StringLength(45, MinimumLength = 2)]
    [Display(Name = "Department")]
    public string Department { get; set; }
}
