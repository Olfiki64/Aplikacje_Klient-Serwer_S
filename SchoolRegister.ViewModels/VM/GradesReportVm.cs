using SchoolRegister.Model.DataModels;

namespace SchoolRegister.ViewModels.VM
{
    public class GradesReportVm
    {
        public string StudentFirstName { get; set; } = null!;
        public string StudentLastName { get; set; } = null!;
        public string GroupName { get; set; } = null!;
        public string ParentName { get; set; } = null!;
        public IDictionary<string,List<GradeScale>> StudentGradesPerSubject { get; set; } = null!;
        public double AverageGrade { get; set; }
        public IDictionary<string, double> AverageGradePerSubject { get; set; } = null!;


    }

}