using System;
using System.Security.Cryptography.X509Certificates;

class Grade {
    public DateTime DateOfIssue  {get;set;}
    public GradeScale GradeValue {get;set;}
    public Subject Subject {get;set;}
    public int SubjectId {get;set;}
    public int  StudentId {get;set;}
    public Student  Student {get; set;}

    public Grade() {}



}