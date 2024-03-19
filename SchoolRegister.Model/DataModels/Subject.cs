using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;


namespace SchoolRegister.Model.DataModels
{
public class Subject
{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}
    public IList<SubjectGroup> SubjectGroups {get; set;}
    public Teacher Teacher {get; set;}
    public int? TeacherId {get; set;}
    public IList<Grade> Grades{get; set;}
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