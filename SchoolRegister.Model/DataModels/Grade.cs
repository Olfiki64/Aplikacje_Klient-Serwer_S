using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
namespace SchoolRegister.Model.DataModels;

public class Grade
{
    public DateTime DateOfIssue{get;set;}
    public virtual GradeScale GradeValue{get;set;}
    public virtual Subject Subject{get;set;} = default!;

    public int SubjectId{get;set;}
    public virtual Student Student{get;set;} = default!;
    public int StudentId{get;set;}

    // public Grade()
    // {
    //     DateOfIssue = new DateTime();
    //     GradeValue = new GradeScale();
    //     Subject = new Subject();
    //     SubjectId = 0;
    //     StudentId = 0;
    //     Student = new Student();
    // }
}