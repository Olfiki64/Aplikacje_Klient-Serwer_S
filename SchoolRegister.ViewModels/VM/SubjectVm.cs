using System.Text.RegularExpressions;

namespace SchoolRegister.ViewModels.VM;
public class SubjectVm
{
public int Id { get; set; }
public string Name { get; set; } = null!;
public string Description { get; set; } = null!;
public IList<Group> Groups { get; set; } = null!;
public string TeacherName { get; set; } = null!;
public int? TeacherId { get; set; }
}