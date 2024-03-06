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
        public double AverageGrade{get;}

    }
}