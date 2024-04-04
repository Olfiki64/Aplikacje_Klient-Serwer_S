using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Teacher:User
    {
        public virtual IList<Subject> Subjects {get;set;}
        public string Title {get;set;} = null!;

        public Teacher () 
        {
            Subjects = new List<Subject>();

        }
        

    }
}