using System;
using System.Threading.Tasks;
using Invoca.Core.Client;
using Invoca.Core;

namespace Invoca.Transaction.Client
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
