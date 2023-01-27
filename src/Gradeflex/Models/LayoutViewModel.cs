namespace Gradeflex.Models;

public class LoginViewModel
{
    public bool IsStudentLoggedIn { get; set; } = false;
    public bool IsProfessorLoggedIn { get; set; } = false;
    public bool IsSecretaryLoggedIn { get; set; } = false;
}
