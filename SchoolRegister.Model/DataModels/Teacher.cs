using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Teacher : User
    {
        public IList<Subject> Subjects {get; set;} = null!;
        public string Title {get; set;} = null!;
        Teacher(){}   
    }
}