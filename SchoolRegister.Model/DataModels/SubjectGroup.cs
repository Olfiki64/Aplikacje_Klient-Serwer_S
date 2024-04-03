using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
namespace SchoolRegister.Model.DataModels;

public class SubjectGroup {
    public virtual Subject Subject{get;set;} = default!;
    [ForeignKey("Subject")]
    public int? SubjectId{get;set;}
    public virtual Group Group{get;set;} = default!;
    [ForeignKey("Group")]
    public int? GroupId{get;set;}
    public SubjectGroup() {

        SubjectId = 0;
        GroupId = 0;
        Subject = new Subject();
        Group = new Group();
    }
}