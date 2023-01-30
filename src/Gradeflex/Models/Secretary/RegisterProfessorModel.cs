using System.ComponentModel.DataAnnotations;

namespace Gradeflex.Models.Secretary;

public class RegisterProfessorModel
{
    [Required]
    [RegularExpression(@"^\d{9}$", ErrorMessage = "The value must be exactly 9 digits")]
    [Display(Name = "Afm")]
    public int Afm { get; set; }
    [Required]
    [StringLength(45, MinimumLength = 2)]
    [Display(Name = "First Name")]
    public string Name { get; set; }
    [Required]
    [StringLength(45, MinimumLength = 2)]
    [Display(Name = "Last Name")]
    public string Surname { get; set; }
    [Required]
    [StringLength(45, MinimumLength = 2)]
    [Display(Name = "Department")]
    public string Department { get; set; }

    [Required]
    [StringLength(45, MinimumLength = 5)]
    [Display(Name = "Username")]
    public string Username { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 5)]
    [Display(Name = "Password")]
    public string Password { get; set; }
}
