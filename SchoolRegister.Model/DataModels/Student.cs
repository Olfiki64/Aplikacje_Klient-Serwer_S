using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace SchoolRegister.Model.DataModels;

public class Student: User
{
    public virtual Group? Group {get; set;} = null!;
    public int? GroupId {get; set;} = null;
    public virtual IList<Grade> Grades { get; set; }
    public virtual Parent Parent { get; set; }
    public int? ParentId { get; set; }
    public double AverageGrade {get;}
    public IDictionary<string, double> AverageGradesPerSubject {get;}
    public IDictionary<string, List<GradeScale>> GradesPerSubject {get;}
    
}
