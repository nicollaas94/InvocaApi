using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoca.Services;

namespace Invoca.Client
{
    class InvocaSoapClientMock<T> : IInvocaClient<T> where T : new()
    {
        public Result<T> Execute()
        {
            throw new NotImplementedException();
        }

        public async Task<Result<T>> ExecuteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
