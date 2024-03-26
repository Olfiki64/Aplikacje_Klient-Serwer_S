using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

public class SubjectGroup
{
    public virtual Subject Subject
    {
        get;
        set;
    }

    public int SubjectId
    {
        get;
        set;
    }

    public virtual Group Group
    {
        get;
        set;
    }

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