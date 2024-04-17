using System.Linq.Expressions;
using SchoolRegister.Model.DataModels;
using SchoolRegister.ViewModels.VM;

namespace SchoolRegister.Services.Interfaces;

public interface ITeacherService
{
    public TeacherVm GetTeacher(Expression<Func<Teacher, bool>> filterPredicate);
    public IEnumerable<TeacherVm> GetTeachers(Expression<Func<Teacher, bool>> filterPredicate = null);
    public IEnumerable<GroupVm> GetTeachersGroups(TeachersGroupsVm getTeachersGroups);
}