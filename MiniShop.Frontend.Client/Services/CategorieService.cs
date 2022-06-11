using AutoMapper;
using MiniShop.Frontend.Client.Dtos;
using MiniShop.Frontend.Client.Models;
using Serilog;
using System;
using Weick.Orm.Core;

namespace MiniShop.Frontend.Client.Services
{
    public class CategorieService : BaseService<Categorie, CategorieDto, int>, ICategorieService, IDependency
    {
        public CategorieService(Lazy<IMapper> mapper, IUnitOfWork unitOfWork, ILogger logger, Lazy<IRepository<Categorie>> repository) : base(mapper, unitOfWork, logger, repository)
        {
        }
    }
}
