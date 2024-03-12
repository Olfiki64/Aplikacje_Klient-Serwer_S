
using SchoolRegister.Model.DataModels;

class Parent : User {

    public IList<Student> Students {get;set;}
    public Parent(){
        Students= new List<Student>();
    }


}