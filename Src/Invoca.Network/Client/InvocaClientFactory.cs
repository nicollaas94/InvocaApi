using Invoca.Core;
using Invoca.Core.Client;
using Invoca.Core.Services;
using System;

namespace Invoca.Network.Client
{
    class InvocaClientFactory
    {
        internal static IInvocaClient<T> CreateClient<T>(IInvocaService service) where T : new()
        {
            var config = Bootstrap.GetConfig();

            if (config.Mode == InvocaApiMode.Production)
                return Create<T>(service);
            else if (config.Mode == InvocaApiMode.Development)
                return new InvocaNetworkClientMock<T>();
            return new InvocaNetworkClientMock<T>();
        }

        private static IInvocaClient<T> Create<T>(IInvocaService service) where T : new()
        {
            return new InvocaNetworkClient<T>(service);
        }

        private static IInvocaClient<T> CreateMock<T>() where T : new()
        {
            throw new NotImplementedException();
        }
    }
}
