using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
public class Subject
{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}
    public virtual IList <SubjectGroup> SubjectGroups {get; set;}
    public virtual Teacher Teacher {get; set;}
    public int? TeacherId {get; set;}
    public virtual IList<Grade> Grades{get; set;}
    public Subject(){
        Id = 0;
        TeacherId = 0;
        Name = "empty";
        Description = "empty";
        SubjectGroups = new List<SubjectGroup>();
        Grades = new List<Grade>();
        Teacher = new Teacher();
        }
}
}