using System.ComponentModel.DataAnnotations;

public class Group
{
    [Key]
    public int Id
    {
        get;
        set;
    }
    
    [Required]
    public string Name
    {
        get;
        set;
    }

    public virtual IList<Student> Students
    {
        get;
        set;
    }

    public virtual IList<SubjectGroup> SubjectGroups
    {
        get;
        set;
    }

    public Group()
    {
        Id = 0;
        Name = "brak";
        Students = new List<Student>();
        SubjectGroups = new List<SubjectGroup>();
    }
}