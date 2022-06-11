using AutoMapper;
using MiniShop.Frontend.Client.Dtos;
using MiniShop.Frontend.Client.Models;
using Serilog;
using System;
using Weick.Orm.Core;

namespace MiniShop.Frontend.Client.Services
{
    public class UnitService : BaseService<Unit, UnitDto, int>, IUnitService, IDependency
    {
        public UnitService(Lazy<IMapper> mapper, IUnitOfWork unitOfWork, ILogger logger, Lazy<IRepository<Unit>> repository) : base(mapper, unitOfWork, logger, repository)
        {
        }
    }
}
