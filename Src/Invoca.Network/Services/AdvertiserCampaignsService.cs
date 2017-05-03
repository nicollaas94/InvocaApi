using Invoca.Network.Client;
using System.Collections.Generic;
using Invoca.Core.Services;
using Invoca.Core.Client;
using Invoca.Core;
using Invoca.Core.Model;
using Invoca.Core.Model.Network;

namespace Invoca.Network.Services
{
    public class AdvertiserCampaignsService: IInvocaService
    {
        public Method RequestType { get; private set; }
        public string Url { get; private set; }
        public string Headers { get; private set; }
        public object Parameters { get; private set; }

        public IInvocaClient<List<AdvertiserCampaingResponse>> GetCampaingsForAdvertiser(int advertiserId)
        {
            this.Url = $"{Bootstrap.GetConfig().NetworkId}/advertisers/{advertiserId}/advertiser_campaigns.json";
            // this.Parameters = parameter;
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<List<AdvertiserCampaingResponse>>(this);
        }

        public IInvocaClient<AdvertiserCampaingResponse> GetSpecifcCampaingForAdvertiser(int advertiserId,int campaingId)
        {
            this.Url = $"{Bootstrap.GetConfig().NetworkId}/advertisers/{advertiserId}/advertiser_campaigns/{campaingId}.json";
            // this.Parameters = parameter;
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<AdvertiserCampaingResponse>(this);
        }
    }
}
