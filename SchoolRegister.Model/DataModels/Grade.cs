using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels{
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
}