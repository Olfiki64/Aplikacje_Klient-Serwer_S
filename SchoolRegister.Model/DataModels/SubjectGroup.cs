using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
namespace SchoolRegister.Model.DataModels;

public class SubjectGroup
{
    public virtual Subject Subject{get;set;}
    [ForeignKey("Subject")]
    public int? SubjectId{get;set;}
    public Group Group{get;set;}
    [ForeignKey("Group")]
    public int? GroupId{get;set;}

    public SubjectGroup()
    {
        Subject = new Subject();
        SubjectId = 0;
        Group = new Group();
        GroupId = 0;
    }
}