using AutoMapper;
using Castle.Core.Logging;
using SchoolRegister.DAL.EF;

namespace SchoolRegister.Services.ConcreteServices
{
public abstract class BaseService {
protected readonly ApplicationDbContext DbContext = null!;
protected readonly ILogger Logger = null!;
protected readonly IMapper Mapper = null!;
        private Microsoft.Extensions.Logging.ILogger logger;

        public BaseService (ApplicationDbContext dbContext, IMapper mapper, ILogger logger) {
DbContext = dbContext;
Logger = logger;
Mapper = mapper;
}

        protected BaseService(ApplicationDbContext dbContext, IMapper mapper, Microsoft.Extensions.Logging.ILogger logger)
        {
            DbContext = dbContext;
            Mapper = mapper;
            this.logger = logger;
        }
    }
}