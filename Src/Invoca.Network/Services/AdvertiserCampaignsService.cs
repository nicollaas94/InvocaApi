using Invoca.Network.Client;
using System.Collections.Generic;
using Invoca.Core.Services;
using Invoca.Core.Client;
using Invoca.Core;
using Invoca.Core.Model;
using Invoca.Core.Model.Network;
using Invoca.Core.Model.Network.QuickStats;
using Invoca.Core.Model.Network.Advertiser.Campaigns;

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
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<List<AdvertiserCampaingResponse>>(this);
        }

        public IInvocaClient<AdvertiserCampaingResponse> GetSpecifcCampaingForAdvertiser(int advertiserId,int campaingId)
        {
            this.Url = $"{Bootstrap.GetConfig().NetworkId}/advertisers/{advertiserId}/advertiser_campaigns/{campaingId}.json";
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<AdvertiserCampaingResponse>(this);
        }

        public IInvocaClient<AdvertiserQuickStatsResponse> GetQuickStats(int advertiserIdFromNetwork, int advertiserCampaignIdFromNetwork)
        {
            this.Url = $"{Bootstrap.GetConfig().NetworkId}/advertisers/{advertiserIdFromNetwork}/advertiser_campaigns/{advertiserCampaignIdFromNetwork}/quick_stats.json";
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<AdvertiserQuickStatsResponse>(this);
        }
    }
}
