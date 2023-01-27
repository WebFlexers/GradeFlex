using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;

namespace Gradeflex.Models.Login;

public class UserModel
{
    [Required]
    [StringLength(45, MinimumLength = 5)]
    [Display(Name = "Username")]
    public string Username { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 5)]
    [Display(Name = "Password")]
    public string Password { get; set; }
}
