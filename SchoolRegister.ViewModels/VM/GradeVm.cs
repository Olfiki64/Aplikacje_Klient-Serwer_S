using System;
using System.Collections.Generic;

namespace SchoolRegister.ViewModels.VM
{
    public class GradeVm
    {
        public DateTime DateOfIssue { get; set; }
        public int StudentId { get; set; }
        public int SubjectId {get; set;}
        public int GradeValue { get; set; }
        public string Subject { get; set; } = null!;
        public string Student { get; set; } = null!;
}

}