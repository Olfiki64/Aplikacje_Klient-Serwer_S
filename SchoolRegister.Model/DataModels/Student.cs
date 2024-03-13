using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Student
    {
        public Group {get; set;}
        public int? GruopId {get; set;}
        public IList<Grade>  Grades {get; set;}
        public Parent {get; set;}

    }
}