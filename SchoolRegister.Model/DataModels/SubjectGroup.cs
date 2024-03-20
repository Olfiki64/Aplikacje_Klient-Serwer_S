using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

public class SubjectGroup
{
    public Subject Subject
    {
        get;
        set;
    }

    //[Key, Column(Order = 0]
    public int SubjectId
    {
        get;
        set;
    }

    public Group Group
    {
        get;
        set;
    }

    //[Key, Column(Order = 1)]
    public int GroupId
    {
        get;
        set;
    }

    public SubjectGroup()
    {
        Subject = new Subject();
        SubjectId = 0;
        Group = new Group();
        GroupId = 0;
    }
}