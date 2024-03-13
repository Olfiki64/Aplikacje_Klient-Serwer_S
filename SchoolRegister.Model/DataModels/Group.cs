using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Group
    {
        public int Id {get;set;}
        public string Name {get;set;}=null!;
        public IList<Student> Students{get;set;}=null!;
        public IList<SubjectGroup> SubjectGroups {get;set;}=null!;

        public Group(){
            
        }

    }
}