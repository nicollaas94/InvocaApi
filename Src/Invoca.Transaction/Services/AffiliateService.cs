using Invoca.Transaction.Client;
using System.Collections.Generic;
using Invoca.Core.Services;
using Invoca.Core.Client;
using Invoca.Core;
using Invoca.Core.Model;

namespace Invoca.Transaction.Services
{
    public class AffiliateService : IInvocaService
    {
        public Method RequestType { get; private set; }
        public string Url { get; private set; }
        public string Headers { get; private set; }
        public object Parameters { get; private set; }
        
        public IInvocaClient<List<Response>> GetAffiliate(QueryParameters np)
        {
            this.Url = $"affiliates/transactions/{Bootstrap.GetConfig().AffiliateId}.json";
            RequestType = Method.GET;
            this.Parameters = np;
            return InvocaClientFactory.CreateClient<List<Response>>(this);
        }
    }
}
