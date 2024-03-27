using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Teacher : User
    {
        private IList<Subject> Subjects =null!;
        public string Title{get;set;}=null!;
        public Teacher(){}
    }
}