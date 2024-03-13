
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using SchoolRegister.Model.DataModels;

public class Subject 
{
    [Key]
    public int Id
    {
        get;
        set;
    }
    [Required]

    public string Name 
    {
        get;
        set;
    }

    public string Description
    {
        get;
        set;
    }

    public IList<SubjectGroup> SubjectGroups
    {
        get;
        set;
    }

    public Teacher Teacher
    {
        get;
        set;
    }

    public int? TeacherId
    {
        get;
        set;
    }

    public IList<Grade> Grades
    {
        get;
        set;
    }

    public Subject()
    {
        Id = 0;
        Name = "brak";
        Description = "brak";
        SubjectGroups = new List<SubjectGroup>();
        Teacher = new Teacher();
        TeacherId = 0;
        Grades = new List<Grade>();
    }


}