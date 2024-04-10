namespace SchoolRegister.ViewModels.VM;

public class StudentVm
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? ParentName { get; set; }
    public string? ParentEmail { get; set; }
    public string? ParentPhoneNumber { get; set; }
    public int GroupId { get; set; }
    public GroupVm Group { get; set; } = null!;
}