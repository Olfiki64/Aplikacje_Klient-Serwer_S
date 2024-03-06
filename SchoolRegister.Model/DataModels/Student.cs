using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public Group Group {get; set;} = null!;
        public int? Groupid {get; set;} = null!;
        public IList<Grade> Grades {get; set;} = null!;
        public Parent Parent {get; set;} = null!;
        public int? ParentId {get; set;} = null!;
        public double AvarageGrade {get;}
        public IDictionary<string, double> AvarageGradePerSubject {get;} = null!;
        public IDictionary<string, List<GradeScale>> GradePerSubject {get;} = null!;
        Student(){}
    }
}