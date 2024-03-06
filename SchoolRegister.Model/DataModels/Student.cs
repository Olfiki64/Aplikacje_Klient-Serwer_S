using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
namespace SchoolRegister.Model.DataModels;
public class Student : User
{
    public Group Group {get; set;} = null!;
    public int? GroupId {get; set;}
    public IList<Grade> Grades {get; set;} = null!;
    public Parent Parent {get; set;} = null!;
    public int? ParentID {get; set;}


}