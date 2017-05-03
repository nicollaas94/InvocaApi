using System;

namespace Invoca.Core.Model.Network
{
    public class BudgetCapAlert
    {
        public double BudgetAmount { get; set; }
        public string BudgetCurrency { get; set; }
        public string ResetPeriod { get; set; }
        public DateTime StartAt { get; set; }
        public double TotalAmount { get; set; }
        public string TimeZone { get; set; }
    }
}