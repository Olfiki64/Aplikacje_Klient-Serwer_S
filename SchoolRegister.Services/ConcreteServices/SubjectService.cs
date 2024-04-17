using SchoolRegister.Services.ConcreteServices;
using SchoolRegister.Services.Interfaces;

public class SubjectServices : BaseService, ISubjectService
{
    public SubjectServices(ApplicationDbContext dbContext, IMapper mapper, ILogger logger) : base(dbContext, mapper, logger)
    {
    }

    public SubjectVm AddOrUpdateSubject(AddOrUpdateSubjectVm addOrUpdateVm)
    {
        throw new NotImplementedException();
    }

    public SubjectVm GetSubject(Expression<Func<Subject, bool>> filterExpression)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<SubjectVm> GetSubjects(Expression<Func<Subject, bool>> filterExpression = null)
    {
        throw new NotImplementedException();
    }
}