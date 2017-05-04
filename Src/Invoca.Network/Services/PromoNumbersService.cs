using Invoca.Network.Client;
using System.Collections.Generic;
using Invoca.Core.Services;
using Invoca.Core.Client;
using Invoca.Core;
using Invoca.Core.Model.Network.PromoNumbers;

namespace Invoca.Network.Services
{
    public class PromoNumbersService : IInvocaService
    {
        public Method RequestType { get; private set; }
        public string Url { get; private set; }
        public string Headers { get; private set; }
        public object Parameters { get; private set; }

        public IInvocaClient<List<PromoNumbersResponse>> GetAllAdvertiserPromoNumbers(int advertiserIdFromNetwork, int advertiserCampaignIdFromNetwork)
        {  
            this.Url = $"{Bootstrap.GetConfig().NetworkId}/advertisers/{advertiserIdFromNetwork}/advertiser_campaigns/{advertiserCampaignIdFromNetwork}/promo_numbers.json";
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<List<PromoNumbersResponse>>(this);
        }

        public IInvocaClient<List<PromoNumbersResponse>> GetAllAffiliatePromoNumbers(int advertiserIdFromNetwork, int advertiserCampaignIdFromNetwork, int affiliateIdFromNetwork)
        {
            this.Url = $"{Bootstrap.GetConfig().NetworkId}/advertisers/{advertiserIdFromNetwork}/advertiser_campaigns/{advertiserCampaignIdFromNetwork}/" +
                 $"affiliates{affiliateIdFromNetwork}/affiliate_campaigns/promo_numbers.json";
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<List<PromoNumbersResponse>>(this);
        }

        public IInvocaClient<PromoNumbersResponse> GetSingleAdvertiserPromoNumber(int advertiserIdFromNetwork, int advertiserCampaignIdFromNetwork, int promoNumber)
        {
            this.Url = $"{Bootstrap.GetConfig().NetworkId}/advertisers/{advertiserIdFromNetwork}/advertiser_campaigns/{advertiserCampaignIdFromNetwork}/promo_numbers/{promoNumber}.json";
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<PromoNumbersResponse>(this);
        }

        public IInvocaClient<PromoNumbersResponse> GetSingleAffiliatePromoNumber(int advertiserIdFromNetwork, int advertiserCampaignIdFromNetwork, int affiliateIdFromNetwork, int promoNumber)
        {
            this.Url = $"{Bootstrap.GetConfig().NetworkId}/advertisers/{advertiserIdFromNetwork}/advertiser_campaigns/{advertiserCampaignIdFromNetwork}/" +
                $"affiliates{affiliateIdFromNetwork}/affiliate_campaigns/promo_numbers/{promoNumber}.json";
            RequestType = Method.GET;
            return InvocaClientFactory.CreateClient<PromoNumbersResponse>(this);
        }
    }
}
