using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
namespace SchoolRegister.Model.DataModels;
public class Student : User
{
public Group Group { get; set; } = Group.Now;
public int? GroupId { get; set; } = null!;
public IList<Grade> Grades { get; set; } = null!;
public Parent Parent { get; set; } = Parent.Now;

public int? ParentId { get; set; } = null!;

public double AverageGrade { get{return AverageGrade;} }

public IDictionary<string,double> AverageGradePerSubject { get{return AverageGradePerSubject; };

public IDictionary<string,List<GradeScale>> GradesPerSubject {get{return GradesPerSubject;} };

}