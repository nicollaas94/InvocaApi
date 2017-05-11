using Invoca.Network.Client;
using System.Collections.Generic;
using Invoca.Core.Services;
using Invoca.Core.Client;
using Invoca.Core;
using Invoca.Core.Model.Network;
using Invoca.Core.Model.Network.Advertiser;

namespace Invoca.Network.Services
{
    public class AdvertiserService: IInvocaService
    {
        public Method RequestType { get; private set; }
        public string Url { get; private set; }
        public string Headers { get; private set; }
        public object Parameters { get; private set; }

        public IInvocaClient<List<AdvertiserResponse>> GetAdvertisers()
        {
            this.Url = $"{Bootstrap.GetConfig().NetworkId}/advertisers.json";
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<List<AdvertiserResponse>>(this);
        }

        public IInvocaClient<AdvertiserCampaingResponse> GetSpecifcAdvertiser(int advertiserIdFromNetwork)
        {
            this.Url = $"{Bootstrap.GetConfig().NetworkId}/advertisers/{advertiserIdFromNetwork}.json";
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<AdvertiserCampaingResponse>(this);
        }
    }
}
