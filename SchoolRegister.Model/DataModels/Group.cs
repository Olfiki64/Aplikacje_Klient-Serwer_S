using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
namespace SchoolRegister.Model.DataModels;

public class Group
{
public int Id{get;set;}
public string Name{get;set;} = string.Empty;
public virtual IList<Student> Students{get;set;} = default!;
public virtual IList<SubjectGroup> SubjectGroups{get;set;} = default!;

// public Group()
// {
//     Id = 0;
//     Name = "empty";
//     Students = new List<Student>();
//     SubjectGroups = new List<SubjectGroup>();
// }
}