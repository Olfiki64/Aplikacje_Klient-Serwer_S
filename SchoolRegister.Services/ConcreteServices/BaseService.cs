using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Castle.Core.Logging;
using SchoolRegister.DAL.EF;

namespace SchoolRegister.Services.ConcreteServices
{
public abstract class BaseService {
protected readonly ApplicationDbContext DbContext = null!;
protected readonly ILogger Logger = null!;
protected readonly IMapper Mapper = null!;
public BaseService (ApplicationDbContext dbContext, IMapper mapper, ILogger logger) {
DbContext = dbContext;
Logger = logger;
Mapper = mapper;
}
}
}