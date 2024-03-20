using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Parent : User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public IList<Student> Students { get; set; }
    public User User { get; set; }
    public string? IdentityUserId { get; set; }
    public Parent()
    {
    }
}
}
