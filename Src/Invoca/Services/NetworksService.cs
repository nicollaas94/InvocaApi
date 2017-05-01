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
    public class NetworksService : IInvocaService
    {
        public Method RequestType { get; private set; }
        public string Url { get; private set; }
        public string Headers { get; private set; }
        public object Parameters { get; private set; }

        // https://mynetwork.invoca.net/api/2016-10-01/networks/transactions/33.csv?limit=50&exclude_columns=calling_phone_number,recording&start_after_transaction_id=C624DA2C-CF3367C3&oauth_token=YbcFH

        public IInvocaClient<List<Response>> GetNetwork(QueryParameters np)
        {
            this.Url = $"networks/transactions/{Bootstrap.GetConfig().NetworkId}.json";
            RequestType = Method.GET;
            this.Parameters = np;
            return InvocaClientFactory.CreateSoap<List<Response>>(this);
        }

    }
}
