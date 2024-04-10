using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolRegister.ViewModels.VM;
public class GradeVm
{
    public DateTime DateOfIssue
    {
        get;
        set;
    }

    public virtual GradeScale GradeValue
    {
        get;
        set;
    }

    public virtual Subject Subject
    {
        get;
        set;
    }=null!;

    public int SubjectId
    {
        get;
        set;
    }

    public int StudentId
    {
        get;
        set;
    }

    public virtual Student Student
    {
        get;
        set;
    }=null!;

}