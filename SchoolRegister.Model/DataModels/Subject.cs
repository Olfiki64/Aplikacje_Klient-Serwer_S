using System.Dynamic;

namespace SchoolRegister.Model.DataModels;

public class Subject
{
    public int Id {get; set;}
    public string? Name {get; set;}
    public string? Description {get; set;}
    public virtual IList<SubjectGroup>? SubjectGroups {get; set;}
    public virtual Teacher? Teacher {get; set;}
    public string? Name {get; set;}
    public string? Description {get; set;}
    public IList<SubjectGroup>? SubjectGroups {get; set;}
    public Teacher? Teacher {get; set;}
    public int? TeacherId {get; set;}
    public virtual IList<Grade>? Grades {get; set;}
}
