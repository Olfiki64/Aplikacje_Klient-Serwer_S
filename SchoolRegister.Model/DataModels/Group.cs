using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
namespace SchoolRegister.Model.DataModels;

public class Group
{
public int Id{get;set;}
public string Name{get;set;}
public IList<Student> Students{get;set;}
public IList<SubjectGroup> SubjectGroups{get;set;}

public Group()
{
    Id = 0;
    Name = "empty";
    Students = new List<Student>();
    SubjectGroups = new List<SubjectGroup>();
}
}