using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace SchoolRegister.Model.DataModels;

public class Student: User
{
    public Group Group {get; set;} = null!;
    public int? groupId {get; set;} = null;
    public IList<Grade> Grades { get; set; }
    public Parent Parent { get; set; }
    public int? parentId { get; set; }
    public double AverageGrade {get;}
    public IDictionary<string, double> AverageGradesPerSubject {get;}
    public IDictionary<string, List<GradeScale>> GradesPerSubject {get;}

    
}
