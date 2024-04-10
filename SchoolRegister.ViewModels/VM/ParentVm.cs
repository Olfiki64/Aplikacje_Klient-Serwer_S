using SchoolRegister.Model.DataModels;
namespace SchoolRegister.ViewModels.VM;
public class ParentVm : UserVm
{
    public virtual IList<Student> Students
    {
        get;
        set;
    }=null!;

}