using System.Collections.Generic;

namespace Invoca.Core.Model.Network.Advertiser.Campaigns
{
    public class CurrentTerms
    {
        public string Description { get; set; }
        public string Timezone { get; set; }
        public string Visibility { get; set; }
        public string CreatedAt { get; set; }
        public string Id { get; set; }
        public bool Operating247 { get; set; }
        public string GoLiveDate { get; set; }
        public string DefaultCreativeIdFromNetwork { get; set; }
        public string CampaignLanguage { get; set; }
        public string CampaignCountry { get; set; }
        public AdvertiserPayin AdvertiserPayin { get; set; }
        public string PricingType { get; set; }
        public IvrTree IvrTree { get; set; }
        public string AutoApprove { get; set; }
        public string ExpirationDate { get; set; }
        public string CampaignType { get; set; }
        public AffiliatePayout AffiliatePayout { get; set; }
        public string UpdatedAt { get; set; }
        public string Url { get; set; }
        public Hours Hours { get; set; }
        public List<NamedRegion> NamedRegions { get; set; }
        public string IdFromNetwork { get; set; }
        public BudgetActivities BudgetActivities { get; set; }
    }
}