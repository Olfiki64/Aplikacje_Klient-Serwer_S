
class SubjectGroup {
    public Subject Subject {get;set;}
    public int SubjectId{get;set;}
    public Group Group {get;set;}
    public  int GroupId {get;set;}
    public SubjectGroup() {

        SubjectId = 0;
        GroupId = 0;
        Subject = new Subject();
        Group = new Group();
    }
}