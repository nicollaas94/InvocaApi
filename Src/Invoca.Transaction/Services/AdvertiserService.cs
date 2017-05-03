using Invoca.Transaction.Client;
using System.Collections.Generic;
using Invoca.Core.Services;
using Invoca.Core.Client;
using Invoca.Core;
using Invoca.Core.Model;

namespace Invoca.Transaction.Services
{
    public class AdvertiserService: IInvocaService
    {
        public Method RequestType { get; private set; }
        public string Url { get; private set; }
        public string Headers { get; private set; }
        public object Parameters { get; private set; }

        public IInvocaClient<List<Response>> GetAdvertiser(QueryParameters parameter)
        {
            this.Url = $"advertisers/transactions/{Bootstrap.GetConfig().AdvertiserId}.json?";
            this.Parameters = parameter;
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<List<Response>>(this);
        }
    }
}
