using System.ComponentModel;
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

    public double AverageGrade
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
    }

    public Student() : base()
    {
        Group = new Group();
        GroupId = 0;
        Grades = new List<Grade>();
        Parent = new Parent();
        ParentId = 0;
        AverageGrade = 0.0;
        AverageGradePerSubject = new Dictionary<string,double>();
        GradePerSubject = new Dictionary<string,List<GradeScale>>();
    }





}