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
    public class AffiliateService : IInvocaService
    {
        public Method RequestType { get; private set; }
        public string Url { get; private set; }
        public string Headers { get; private set; }
        public object Parameters { get; private set; }
        
        public IInvocaClient<Response> GetAffiliate(QueryParameters np)
        {
            this.Url = $"affiliates/transactions/{Bootstrap.GetConfig().AffiliateId}.json";
            RequestType = Method.GET;
            this.Parameters = np;
            return InvocaClientFactory.CreateSoap<Response>(this);
        }
    }
}
