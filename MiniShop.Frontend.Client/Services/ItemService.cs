using AutoMapper;
using MiniShop.Frontend.Client.Dtos;
using MiniShop.Frontend.Client.Models;
using Serilog;
using System;
using Weick.Orm.Core;

namespace MiniShop.Frontend.Client.Services
{
    public class ItemService : BaseService<Item, ItemDto, int>, IItemService, IDependency
    {
        public ItemService(Lazy<IMapper> mapper, IUnitOfWork unitOfWork, ILogger logger, Lazy<IRepository<Item>> repository) : base(mapper, unitOfWork, logger, repository)
        {
        }
    }
}
