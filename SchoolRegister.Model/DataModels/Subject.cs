using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        public int id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public IList<SubjectGroup>  {get; set;}
        public Teacher {get; set;}
        public IList<Grade > Grades {get; set;}
        public Subject () 
    }
}