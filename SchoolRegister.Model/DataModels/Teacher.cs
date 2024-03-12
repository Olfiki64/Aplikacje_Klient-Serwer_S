
using SchoolRegister.Model.DataModels;

class Teacher:User {
    public IList<Subject> Subjects {get;set;}
    public string Title {get;set;}
    public Teacher() {
        Subjects = new List<Subject>();
    }

}