using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Group 
{
    public int Id {get;set;}
    public string Name {get;set;}
    public virtual IList<Student> Students {get;set;}
    public virtual IList<SubjectGroup> SubjectGroups {get;set;}
    public Group()
    {
        Id = 0;
        Name = "empty";
        Students = new List<Student>();
        SubjectGroups = new List<SubjectGroup>();
    }
}
}