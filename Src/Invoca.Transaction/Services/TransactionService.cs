using Invoca.Transaction.Client;
using System.Collections.Generic;
using Invoca.Core.Services;
using Invoca.Core.Client;
using Invoca.Core;
using Invoca.Core.Model;
using System;

namespace Invoca.Transaction.Services
{
    public class TransactionService: IInvocaService
    {
        public Method RequestType { get; private set; }
        public string Url { get; private set; }
        public string Headers { get; private set; }
        public object Parameters { get; private set; }        

        public IInvocaClient<List<Response>> GetAdvertiser(QueryParameters parameter)
        {
            lock (this)
            {
                this.Url = $"advertisers/transactions/{Bootstrap.GetConfig().AdvertiserId}.json?";
                this.Parameters = parameter;
                RequestType = Method.GET;
                return InvocaClientFactory.CreateClient<List<Response>>(this);
            }           
        }

        public IInvocaClient<List<Response>> GetNetwork(QueryParameters np)
        {
            lock (this)
            {
                this.Url = $"networks/transactions/{Bootstrap.GetConfig().NetworkId}.json";
                RequestType = Method.GET;
                this.Parameters = np;
                return InvocaClientFactory.CreateClient<List<Response>>(this);
            }
        }

        public IInvocaClient<List<Response>> GetAffiliate(QueryParameters np)
        {
            lock (this)
            {
                this.Url = $"affiliates/transactions/{Bootstrap.GetConfig().AffiliateId}.json";
                RequestType = Method.GET;
                this.Parameters = np;
                return InvocaClientFactory.CreateClient<List<Response>>(this);
            }
        }
    }
}
