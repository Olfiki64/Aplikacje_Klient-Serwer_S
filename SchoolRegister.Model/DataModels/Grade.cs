using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
namespace SchoolRegister.Model.DataModels;

public class Grade
{
    public DateTime DateOfIssue{get;set;}
    public GradeScale GradeValue{get;set;}
    public Subject Subject{get;set;}

    public int SubjectId{get;set;}
    public int StudentId{get;set;}
    public Student Student{get;set;}

    public Grade()
    {
        DateOfIssue = new DateTime();
        GradeValue = new GradeScale();
        Subject = new Subject();
        SubjectId = 0;
        StudentId = 0;
        Student = new Student();
    }
}