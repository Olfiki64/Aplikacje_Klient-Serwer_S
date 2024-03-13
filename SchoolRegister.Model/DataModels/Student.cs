using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using SchoolRegister.Model.DataModels;

public class Student : User
{  
    public Group Group
    {
        get;
        set;
    }

    public int? GroupId
    {
        get;
        set;
    }

    public IList<Grade> Grades
    {
        get;
        set;
    }

    public Parent Parent
    {
        get;
        set;
    }

    public int? ParentId
    {
        get;
        set;
    }

    /*public double AverageGrade
    {
        get;
    }

    public IDictionary<string,double> AverageGradePerSubject
    {
        get;
    }

    public IDictionary<string,List<GradeScale>> GradePerSubject
    {
        get;
    }*/

    public double AverageGrade => Grades == null || Grades.Count == 0 ? 0.0d : Math.Round(Grades.Average(g => (int)g.GradeValue), 1);

    public IDictionary<string, double> AverageGradePerSubject => Grades == null ? new Dictionary<string, double>() :
        Grades.GroupBy(g => g.Subject.Name)
        .Select(g => new { SubjectName = g.Key, AvgGrade = Math.Round(g.Average(avg => (int)avg.GradeValue), 1) })
        .ToDictionary(avg => avg.SubjectName, avg => avg.AvgGrade);

    public IDictionary<string, List<GradeScale>> GradesPerSubject => Grades == null ? new Dictionary<string, List<GradeScale>>() : Grades
        .GroupBy(g => g.Subject.Name)
        .Select(g => new { SubjectName = g.Key, GradeList = g.Select(x => x.GradeValue).ToList() })
        .ToDictionary(x => x.SubjectName, x=> x.GradeList);
    public Student() : base()
    {
        Group = new Group();
        GroupId = 0;
        Grades = new List<Grade>();
        Parent = new Parent();
        ParentId = 0;
        //AverageGrade = 0.0;
        //AverageGradePerSubject = new Dictionary<string,double>();
        //GradePerSubject = new Dictionary<string,List<GradeScale>>();
    }
}