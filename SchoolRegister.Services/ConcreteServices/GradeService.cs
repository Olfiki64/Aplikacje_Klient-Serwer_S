using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SchoolRegister.DAL.EF;
using SchoolRegister.Model.DataModels;
using SchoolRegister.Services.Interfaces;
using SchoolRegister.ViewModels.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace SchoolRegister.Services.ConcreteServices
{
public class GradeService : BaseService, IGradeService
{
    public GradeService(ApplicationDbContext dbContext, IMapper mapper, Castle.Core.Logging.ILogger logger) : base(dbContext, mapper, logger)
    {
    }

    public GradeVm AddGradeToStudent(AddGradeToStudentVm addGradeToStudentVm)
    {
        throw new NotImplementedException();
    }

    public GradesReportVm GetGradesReportForStudent(GetGradesReportVm getGradesVm)
    {
        throw new NotImplementedException();
    }
}
}