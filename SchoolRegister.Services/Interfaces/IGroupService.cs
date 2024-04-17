using System.Linq.Expressions;
using System.Text.RegularExpressions;
using SchoolRegister.ViewModels.VM;

namespace SchoolRegister.Services.Interfaces;

public interface IGroupService
{
    public GroupVm AddOrUpdateGroup(AddOrUpdateGroupVm addOrUpdateGroupVm);
    public StudentVm AttachStudentToGroup(AttachDetachStudentToGroupVm attachStudentToGroupVm);
    public GroupVm AttachSubjectToGroup(AttachDetachSubjectGroupVm attachSubjectGroupVm);
    public SubjectVm AttachTeacherToSubject(AttachDetachSubjectToTeacherVm attachDetachSubjectToTeacherVm);
    public StudentVm DetachStudentFromGroup(AttachDetachStudentToGroupVm detachStudentToGroupVm);
    public GroupVm DetachSubjectFromGroup(AttachDetachSubjectGroupVm detachSubjectGroupVm);
    public SubjectVm DetachTeacherFromSubject(AttachDetachSubjectToTeacherVm attachDetachSubjectToTeacherVm);
    public GroupVm GetGroup(Expression<Func<Group, bool>> filterPredicate);
    public IEnumerable<GroupVm> GetGroups(Expression<Func<Group, bool>> filterPredicate = null);
}