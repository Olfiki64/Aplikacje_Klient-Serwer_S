using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Group
    {
    [Key]
        public int Id {get; set;}

        public string Name {get; set;} = null!;
        public virtual IList<Student> Students {get; set;} = null!;
        public virtual IList<SubjectGroup> SubjectGroups {get; set;} = null!;
        Group(){}
    }
}