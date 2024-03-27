using System;
using System.Security.Cryptography.X509Certificates;

public class Grade {
    public DateTime DateOfIssue  {get;set;}
    public virtual GradeScale GradeValue {get;set;}
    public virtual Subject Subject {get;set;}
    public int SubjectId {get;set;}
    public int  StudentId {get;set;}
    public virtual Student  Student {get; set;}

    public Grade() {

        SubjectId = 0;
        StudentId = 0;
        DateOfIssue = new DateTime();
        GradeValue = new GradeScale();
        Subject = new Subject();
        Student = new Student(); 
    }
}