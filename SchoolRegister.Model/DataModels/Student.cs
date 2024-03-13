using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public Group Group {get;set;}=null!;
        public int? GroupId {get;set;}=null!;
        public IList<Grade> Grades {get;set;}=null!;
        public Parent Parent{get;set;}=null!;
        public int? ParentId {get;set;}=null!;
        //uzupełnić potem V V V
        public double AverageGrade => Grades == null || Grades.Count == 0 ? 0.0d : Math.Round(Grades.Average(g => (int)g.GradeValue), 1);

        public IDictionary<string, double> AverageGradePerSubject => Grades == null ? new Dictionary<string,double>() : Grades.GroupBy(g => g.Subject.Name).Select(g => new { SubjectName = g.Key, AvgGrade = Math.Round(g.Average(avg => (int)avg.GradeValue), 1) }).ToDictionary(avg => avg.SubjectName, avg => avg.AvgGrade);

        public IDictionary<string, List<GradeScale>> GradesPerSubject => Grades ==  null ? new Dictionary<string, List<GradeScale>>()
         : Grades.GroupBy(g => g.Subject.Name).Select(g => new { SubjectName = g.Key, GradeList = g.Select (x => x.GradeValue).ToList() })
         .ToDictionary(x => x.SubjectName, x => x.GradeList);
    }
}