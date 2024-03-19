using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Group 
{
    public int Id {get;set;}
    public string Name {get;set;}
    public IList<Stident> Students {get;set;}
    public IList<SubjectGroup> SubjectGroups {get;set;}
    public SubjectGroup()
    {
        Id = 0;
        Name = "empty";
        Students = new IList<Stident>();
        SubjectGroups = new IList<SubjectGroup>();
    }
}
}