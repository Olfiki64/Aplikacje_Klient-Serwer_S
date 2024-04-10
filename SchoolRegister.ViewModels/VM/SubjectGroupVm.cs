using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace SchoolRegister.ViewModels.VM;
public class SubjectGroupVm
{
    public virtual SubjectVm Subject
    {
        get;
        set;
    }=null!;

    public int SubjectId
    {
        get;
        set;
    }

    public virtual GroupVm Group
    {
        get;
        set;
    }=null!;

    public int GroupId
    {
        get;
        set;
    }
}