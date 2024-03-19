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
    public Subject Subject {get;set;}
    public int SubejctId {get;set;}
    public Group Group {get;set;}
    public int GroupId {get;set;}
    public SubjectGroup()
    {
        Subject = new Subject();
        SubejctId = 0;
        Group = new Group();
        GroupId = 0;
    }
}
}