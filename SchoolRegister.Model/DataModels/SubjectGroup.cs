using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{

public class SubjectGroup 
{
    public virtual Subject Subject {get;set;}
    public int SubjectId {get;set;}
    public virtual Group Group {get;set;}
    public int GroupId {get;set;}
    public SubjectGroup()
    {
        Subject = new Subject();
        SubjectId = 0;
        Group = new Group();
        GroupId = 0;
    }
}
}