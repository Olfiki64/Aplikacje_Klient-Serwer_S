using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
namespace SchoolRegister.Model.DataModels;

public class Subject
{
public int Id{get;set;}
public string Name{get;set;} = null!;
public string Description{get;set;} = string.Empty;

public virtual IList<SubjectGroup> SubjectGroups{get;set;} = default!;

public virtual Teacher Teacher{get;set;} = default!;
public int? TeacherId{get;set;}
public virtual IList<Grade> Grades{get;set;} = default!;

// public Subject()
// {
//     Id = 0;
//     Name = "empty";
//     Description = "empty";
//     SubjectGroups = new List<SubjectGroup>();
//     Teacher = new Teacher();
//     TeacherId = 0;
//     Grades = new List<Grade>();
// }
}