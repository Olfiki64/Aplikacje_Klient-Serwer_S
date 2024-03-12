using SchoolRegister.Model.DataModels;

public class Parent : User
{
    public IList<Student> Students
    {
        get;
        set;
    }

    public Parent() : base()
    {
        Students = new List<Student>();
    }
}