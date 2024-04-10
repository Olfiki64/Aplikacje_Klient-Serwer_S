using Microsoft.AspNetCore.Identity;
namespace SchoolRegister.ViewModels.VM;
public class UserVm : IdentityUser<int>
{
public string FirstName { get; set; } = null!;
public string LastName { get; set; } = null!;
public DateTime RegistrationDate { get; set; } = DateTime.Now;

}
