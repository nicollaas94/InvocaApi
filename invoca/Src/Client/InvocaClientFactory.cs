using Invoca.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoca.Client
{
    class InvocaClientFactory
    {
        internal static IInvocaClient<T> CreateSoap<T>(IInvocaService service) where T : new()
        {
            var config = Bootstrap.GetConfig();

            if (config.Mode == InvocaApiMode.Production)
                return Create<T>(service);
            else if (config.Mode == InvocaApiMode.Development)
                return new InvocaSoapClientMock<T>();
            return new InvocaSoapClientMock<T>();
        }

        private static IInvocaClient<T> Create<T>(IInvocaService service) where T : new()
        {
            return new InvocaClient<T>(service);
        }

        private static IInvocaClient<T> CreateMock<T>() where T : new()
        {
            throw new NotImplementedException();
        }
    }
}
