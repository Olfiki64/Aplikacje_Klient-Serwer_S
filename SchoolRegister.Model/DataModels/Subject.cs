using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Name {get; set;} = null!;
        public string Description {get; set;} = null!;
        public virtual IList<SubjectGroup> SubjectGroups {get; set;} = null!;
        public virtual Teacher Teacher {get; set;} = null!;
        public int? TeacherId {get; set;} = null!;
        public virtual IList<Grade> Grades {get; set;} = null!;
        Subject(){}
}
}