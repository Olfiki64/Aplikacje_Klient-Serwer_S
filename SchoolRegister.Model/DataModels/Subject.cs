using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace SchoolRegister.Model.DataModels{
public class Subject {
    public int Id {get;set;}
    public string Name {get;set;}
    public string Description {get;set;}
    public virtual IList<SubjectGroup> SubjectGroups {get;set;}
    public virtual Teacher Teacher {get;set;}
    public int? TeacherId {get;set;}
    public virtual IList<Grade> Grades {get;set;}
    public Subject(){
        Id = 0;
        TeacherId = 0;
        Name = "puste";
        Description = "puste";
        SubjectGroups = new List<SubjectGroup>();
        Grades = new List<Grade>();
        Teacher = new Teacher();
    }
}
}