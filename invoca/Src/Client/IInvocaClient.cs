using Invoca.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoca.Client
{
    public interface IInvocaClient<T> where T : new()
    {
        Result<T> Execute();

        Task<Result<T>> ExecuteAsync();
    }
}
