using Invoca.Model;
using Invoca.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoca.Services
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
            return InvocaClientFactory.CreateSoap<List<Response>>(this);
        }
    }
}
