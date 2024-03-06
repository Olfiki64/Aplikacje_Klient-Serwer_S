using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Student:User
    {
        public Group Group {get;set;}=null!;
        public int? GroupId {get;set;}=null!;
        public IList<Grade> Grades {get;set;}=null!;
        public Parent Parent{get;set;}=null!;
        public int? ParentId {get;set;}=null!;
        //Uzupełni sie potem
        public double AverageGrade{get;}
    }
}