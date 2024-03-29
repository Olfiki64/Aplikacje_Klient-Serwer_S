namespace SchoolRegister.Model.DataModels;

public class Grade
{
    public DateTime DateOfIssue { get; set; } = DateTime.Now!;
    public virtual GradeScale GradeValue { get; set; }
    public virtual Subject Subject { get; set; } = null!;
    public int SubjectId { get; set; }
    public int StudentId { get; set; }
    public virtual Student Student { get; set; } = null!;
}