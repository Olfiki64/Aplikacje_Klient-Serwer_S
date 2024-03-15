using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
namespace SchoolRegister.Model.DataModels;

public class SubjectGroup
{
    public Subject Subject{get;set;}
    public int SubjectId{get;set;}
    public Group Group{get;set;}
    public int GroupId{get;set;}

    public SubjectGroup()
    {
        Subject = new Subject();
        SubjectId = 0;
        Group = new Group();
        GroupId = 0;
    }
}