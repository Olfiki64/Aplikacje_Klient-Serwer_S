using System.Text.RegularExpressions;

public class SubjectGroup
{
    public Subject Subject
    {
        get;
        set;
    }

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