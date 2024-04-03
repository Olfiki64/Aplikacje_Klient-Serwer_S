using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public Group Group { get; set; }
        public int? GroupId { get; set; }
        public IList<Grade> Grades { get; set; }
        public Parent Parent { get; set; }
        public int? ParentId { get; set; }
        public double AverageGrade { get; set; }
        public IDictionary<string, double> AverageGradePerSubject { get; set; }
        public IDictionary<string, List<GradeScale>> GradesPerSubject { get; set; }
        public User User { get; set; }
        public string? IdentityUserId { get; set; }
        public Student()
        {
        }
    }
}
