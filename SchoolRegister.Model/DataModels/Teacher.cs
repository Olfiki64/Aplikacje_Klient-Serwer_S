
using SchoolRegister.Model.DataModels;

class Teacher:User {
    public IList<Subject> Subjects {get;set;}
    public string Title {get;set;}
    public Teacher() {
        Title = "puste";
        Subjects = new List<Subject>();
    }
}