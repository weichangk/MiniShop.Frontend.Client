using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClientCore;
using Weick.Orm.Core.Result;

namespace MiniShop.Frontend.Client.HttpApis
{
    public interface IExecuteApi
    {
        //Task<IActionResult> ExecuteApiAsync<T>(Func<ITask<ResultModel<T>>> action);
        Task<ResultModel<T>> ExecuteApiAsync<T>(Func<ITask<ResultModel<T>>> action);
    }
}
