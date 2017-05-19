using System.Collections.Generic;

namespace Invoca.Core.Model
{
    public class Hours
    {
        public int monday_open { get; set; }
        public int monday_close { get; set; }
        public bool monday_closed { get; set; }
        public int tuesday_open { get; set; }
        public int tuesday_close { get; set; }
        public bool tuesday_closed { get; set; }
        public int wednesday_open { get; set; }
        public int wednesday_close { get; set; }
        public bool wednesday_closed { get; set; }
        public int thursday_open { get; set; }
        public int thursday_close { get; set; }
        public bool thursday_closed { get; set; }
        public int friday_open { get; set; }
        public int friday_close { get; set; }
        public bool friday_closed { get; set; }
        public int saturday_open { get; set; }
        public int saturday_close { get; set; }
        public bool saturday_closed { get; set; }
        public int sunday_open { get; set; }
        public int sunday_close { get; set; }
        public bool sunday_closed { get; set; }
    }

    public class Root
    {
        public string node_type { get; set; }
        public string destination_phone_number { get; set; }
        public string destination_country_code { get; set; }
        public string destination_extension { get; set; }
        public string prompt { get; set; }
        public string prompt_id_from_network { get; set; }
        public object prompt_url { get; set; }
        public object prompt_received { get; set; }
    }

    public class IvrTree
    {
        public bool record_calls { get; set; }
        public string custom_challenge_prompt_text { get; set; }
        public object custom_challenge_prompt_id_from_network { get; set; }
        public Root root { get; set; }
    }

    public class NamedRegion
    {
        public string name { get; set; }
        public IList<object> regions { get; set; }
    }

    public class AdvertiserPayin
    {
        public object min { get; set; }
        public object max { get; set; }
        public object currency { get; set; }
        public string range { get; set; }
        public string pricing { get; set; }
        public IList<object> policies { get; set; }
    }

    public class Policy
    {
        public string type { get; set; }
        public string condition { get; set; }
        public string currency { get; set; }
        public double amount { get; set; }
    }

    public class AffiliatePayout
    {
        public double? min { get; set; }
        public double? max { get; set; }
        public string currency { get; set; }
        public string range { get; set; }
        public string pricing { get; set; }
        public IList<Policy> policies { get; set; }
    }

    public class BudgetActivities
    {
        public object budget_cap_alert { get; set; }
        public object concurrent_call_cap_alert { get; set; }
        public object periodic_call_cap_alert { get; set; }
    }

    public class CurrentTerms
    {
        public string id_from_network { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public bool operating_24_7 { get; set; }
        public string timezone { get; set; }
        public Hours hours { get; set; }
        public IvrTree ivr_tree { get; set; }
        public IList<NamedRegion> named_regions { get; set; }
        public AdvertiserPayin advertiser_payin { get; set; }
        public AffiliatePayout affiliate_payout { get; set; }
        public string pricing_type { get; set; }
        public BudgetActivities budget_activities { get; set; }
        public string auto_approve { get; set; }
        public string visibility { get; set; }
        public string go_live_date { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public object pause_date { get; set; }
        public string campaign_type { get; set; }
        public string default_creative_id_from_network { get; set; }
        public string campaign_language { get; set; }
    }

    public class Example
    {
        public int id { get; set; }
        public string id_from_network { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string object_url { get; set; }
        public CurrentTerms current_terms { get; set; }
    }


}
