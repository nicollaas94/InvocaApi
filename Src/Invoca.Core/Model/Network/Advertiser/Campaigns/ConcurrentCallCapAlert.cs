using System;

namespace Invoca.Core.Model.Network.Advertiser.Campaigns
{
    public class ConcurrentCallCapAlert
    {
        public double BudgetAmount { get; set; }
        public string BudgetCurrency { get; set; }
        public string ResetPeriod { get; set; }
        public DateTime StartAt { get; set; }
        public string TimeZone { get; set; }
    }
}