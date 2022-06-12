using MiniShop.Frontend.Client.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClientCore;
using Weick.Orm.Core.Result;

namespace MiniShop.Frontend.Client.HttpApis
{
    public interface IUnitApi : IHttpApi
    {
        ITask<ResultModel<List<dynamic>>> GetListByShopIdAsync(Guid shopId);
    }
}
