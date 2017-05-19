namespace Invoca.Core.Model.Network.Advertiser.Campaigns
{
    public class FutureTerms
    {
        public string Description { get; set; }
        public string Timezone { get; set; }
        public string Visibility { get; set; }
        public string CreatedAt { get; set; }
        public string Id { get; set; }
        public bool Operating247 { get; set; }
        public object GoLiveDate { get; set; }
        public string DefaultCreativeIdFromNetwork { get; set; }
        public string CampaignLanguage { get; set; }
        public string CampaignCountry { get; set; }
        public AdvertiserPayin AdvertiserPayin { get; set; }
        public BudgetActivities BudgetActivities { get; set; }
    }
}