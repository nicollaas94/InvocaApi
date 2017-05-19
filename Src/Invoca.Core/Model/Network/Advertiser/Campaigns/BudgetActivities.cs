using System;
using System.Collections.Generic;

namespace Invoca.Core.Model.Network.Advertiser.Campaigns
{
    public class BudgetActivities
    {
        public PeriodicCallCapAlert PeriodicCallCapAlert { get; set; }
        public ConcurrentCallCapAlert ConcurrentCallCapAlert { get; set; }
        public BudgetCapAlert BudgetCapAlert { get; set; }
        public string PricingType { get; set; }
        public IvrTree IvrTree { get; set; }
        public string AutoApprove { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CampaignType { get; set; }
        public AffiliatePayout AffiliatePayout { get; set; }
        public string UpdatedAt { get; set; }
        public string Url { get; set; }
        public Hours Hours { get; set; }
        public List<NamedRegion> NamedRegions { get; set; }
    }
}
