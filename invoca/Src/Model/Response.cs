using RestSharp.Deserializers;
using System;

namespace Invoca.Model
{
    public class Response
    {
        [DeserializeAs(Name = "transaction_id")]
        public string TransactionId { get; set; }

        [DeserializeAs(Name = "corrects_transaction_id")]
        public string CorrectsTransactionId { get; set; }

        [DeserializeAs(Name = "transaction_type")]
        public string TransactionType { get; set; }

        [DeserializeAs(Name = "original_order_id")]
        public string OriginalOrderId { get; set; }

        [DeserializeAs(Name = "advertiser_campaign_id")]
        public string AdvertiserCampaignId { get; set; }

        [DeserializeAs(Name = "advertiser_campaign_id_from_network")]
        public string AdvertiserCampaignIdFromNetwork { get; set; }

        [DeserializeAs(Name = "advertiser_campaign_name")]
        public string AdvertiserCampaignName { get; set; }

        [DeserializeAs(Name = "affiliate_id")]
        public string AffiliateId { get; set; }

        [DeserializeAs(Name = "affiliate_id_from_network")]
        public string AffiliateIdFromNetwork { get; set; }

        [DeserializeAs(Name = "affiliate_name")]
        public string AffiliateName { get; set; }

        [DeserializeAs(Name = "affiliate_commissions_ranking")]
        public string AffiliateCommissionsRanking { get; set; }

        [DeserializeAs(Name = "affiliate_call_volume_ranking")]
        public string AffiliateCallVolumeRanking { get; set; }

        [DeserializeAs(Name = "affiliate_conversion_rate_ranking")]
        public string AffiliateConversionRateRanking { get; set; }

        [DeserializeAs(Name = "media_type")]
        public string MediaType { get; set; }

        [DeserializeAs(Name = "call_source_description")]
        public string CallSourceDescription { get; set; }

        [DeserializeAs(Name = "syndicated_ident")]
        public string SyndicatedIdent { get; set; }

        [DeserializeAs(Name = "promo_line_description")]
        public string PromoLineDescription { get; set; }

        [DeserializeAs(Name = "virtual_line_id")]
        public string VirtualLineId { get; set; }

        [DeserializeAs(Name = "call_result_description_detail_managed_advertiser")]
        public string CallResultDescriptionDetailManagedAdvertiser { get; set; }

        [DeserializeAs(Name = "advertiser_payin_localized")]
        public string AdvertiserPayinLocalized { get; set; }

        [DeserializeAs(Name = "matching_advertiser_payin_policies")]
        public string MatchingAdvertiserPayinPolicies { get; set; }

        [DeserializeAs(Name = "payin_conditions")]
        public string PayinConditions { get; set; }

        [DeserializeAs(Name = "city")]
        public string City { get; set; }

        [DeserializeAs(Name = "region")]
        public string Region { get; set; }

        [DeserializeAs(Name = "qualified_regions")]
        public string QualifiedRegions { get; set; }

        [DeserializeAs(Name = "repeat_calling_phone_number")]
        public string RepeatCallingPhoneNumber { get; set; }

        [DeserializeAs(Name = "calling_phone_number")]
        public string CallingPhoneNumber { get; set; }

        [DeserializeAs(Name = "mobile")]
        public string Mobile { get; set; }

        [DeserializeAs(Name = "duration")]
        public int Duration { get; set; }

        [DeserializeAs(Name = "connect_duration")]
        public int ConnectDuration { get; set; }

        [DeserializeAs(Name = "ivr_duration")]
        public int IvrDuration { get; set; }

        [DeserializeAs(Name = "keypresses")]
        public string Keypresses { get; set; }

        [DeserializeAs(Name = "keypress_1")]
        public string Keypress1 { get; set; }

        [DeserializeAs(Name = "keypress_2")]
        public string Keypress2 { get; set; }

        [DeserializeAs(Name = "keypress_3")]
        public string Keypress3 { get; set; }

        [DeserializeAs(Name = "keypress_4")]
        public string Keypress4 { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_search_engine")]
        public string DynamicNumberPoolReferrerSearchEngine { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_search_keywords")]
        public string DynamicNumberPoolReferrerSearchKeywords { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_search_keywords_id")]
        public string DynamicNumberPoolReferrerSearchKeywordsId { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_ad")]
        public string DynamicNumberPoolReferrerAd { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_ad_id")]
        public string DynamicNumberPoolReferrerAdId { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_ad_group")]
        public string DynamicNumberPoolReferrerAdGroup { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_ad_group_id")]
        public string DynamicNumberPoolReferrerAdGroupId { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_referrer_campaign")]
        public string DynamicNumberPoolReferrerReferrerCampaign { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_referrer_campaign_id")]
        public string DynamicNumberPoolReferrerReferrerCampaignId { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_keyword_match_type")]
        public string DynamicNumberPoolReferrerKeywordMatchType { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param1_name")]
        public string DynamicNumberPoolReferrerParam1Name { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param1_value")]
        public string DynamicNumberPoolReferrerParam1Value { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param2_name")]
        public string DynamicNumberPoolReferrerParam2Name { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param2_value")]
        public string DynamicNumberPoolReferrerParam2Value { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param3_name")]
        public string DynamicNumberPoolReferrerParam3Name { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param3_value")]
        public string DynamicNumberPoolReferrerParam3Value { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param4_name")]
        public string DynamicNumberPoolReferrerParam4Name { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param4_value")]
        public string DynamicNumberPoolReferrerParam4Value { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param5_name")]
        public string DynamicNumberPoolReferrerParam5Name { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param5_value")]
        public string DynamicNumberPoolReferrerParam5Value { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param6_name")]
        public string DynamicNumberPoolReferrerParam6Name { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param6_value")]
        public string DynamicNumberPoolReferrerParam6Value { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param7_name")]
        public string DynamicNumberPoolReferrerParam7Name { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param7_value")]
        public string DynamicNumberPoolReferrerParam7Value { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param8_name")]
        public string DynamicNumberPoolReferrerParam8Name { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param8_value")]
        public string DynamicNumberPoolReferrerParam8Value { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param9_name")]
        public string DynamicNumberPoolReferrerParam9Name { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param9_value")]
        public string DynamicNumberPoolReferrerParam9Value { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param10_name")]
        public string DynamicNumberPoolReferrerParam10Name { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_param10_value")]
        public string DynamicNumberPoolReferrerParam10Value { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_referrer_search_type")]
        public string DynamicNumberPoolReferrerSearchType { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_pool_type")]
        public string DynamicNumberPoolPoolType { get; set; }

        [DeserializeAs(Name = "dynamic_number_pool_id")]
        public int DynamicNumberPoolId { get; set; }

        [DeserializeAs(Name = "start_time_local")]
        public string StartTimeLocal { get; set; }

        [DeserializeAs(Name = "start_time_xml")]
        public DateTime StartTimeXml { get; set; }

        [DeserializeAs(Name = "start_time_utc")]
        public object StartTimeUtc { get; set; }

        [DeserializeAs(Name = "start_time_network_timezone")]
        public string StartTimeNetworkTimezone { get; set; }

        [DeserializeAs(Name = "start_time_network_timezone_xml")]
        public DateTime StartTimeNetworkTimezoneXml { get; set; }

        [DeserializeAs(Name = "recording")]
        public string Recording { get; set; }

        [DeserializeAs(Name = "corrected_at")]
        public string CorrectedAt { get; set; }

        [DeserializeAs(Name = "opt_in_SMS")]
        public int OptInSMS { get; set; }

        [DeserializeAs(Name = "complete_call_id")]
        public string CompleteCallId { get; set; }

        [DeserializeAs(Name = "transfer_from_type")]
        public string TransferFromType { get; set; }

        [DeserializeAs(Name = "notes")]
        public string Notes { get; set; }

        [DeserializeAs(Name = "verified_zip")]
        public string VerifiedZip { get; set; }

        [DeserializeAs(Name = "signal_name")]
        public string SignalName { get; set; }

        [DeserializeAs(Name = "signal_description")]
        public string SignalDescription { get; set; }

        [DeserializeAs(Name = "signal_partner_unique_id")]
        public string SignalPartnerUniqueId { get; set; }

        [DeserializeAs(Name = "signal_occurred_at")]
        public string SignalOccurredAt { get; set; }

        [DeserializeAs(Name = "signal_source")]
        public string SignalSource { get; set; }

        [DeserializeAs(Name = "signal_value")]
        public string SignalValue { get; set; }

        [DeserializeAs(Name = "signal_custom_parameter_1")]
        public string SignalCustomParameter1 { get; set; }

        [DeserializeAs(Name = "signal_custom_parameter_2")]
        public string SignalCustomParameter2 { get; set; }

        [DeserializeAs(Name = "signal_custom_parameter_3")]
        public string SignalCustomParameter3 { get; set; }

        [DeserializeAs(Name = "email_address")]
        public string EmailAddress { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "address1")]
        public string Address1 { get; set; }

        [DeserializeAs(Name = "address2")]
        public string Address2 { get; set; }

        [DeserializeAs(Name = "order_city")]
        public string OrderCity { get; set; }

        [DeserializeAs(Name = "state_or_province")]
        public string StateOrProvince { get; set; }

        [DeserializeAs(Name = "zip_code")]
        public string ZipCode { get; set; }

        [DeserializeAs(Name = "country")]
        public string Country { get; set; }

        [DeserializeAs(Name = "home_phone_number")]
        public string HomePhoneNumber { get; set; }

        [DeserializeAs(Name = "cell_phone_number")]
        public string CellPhoneNumber { get; set; }

        [DeserializeAs(Name = "sku_list")]
        public string SkuList { get; set; }

        [DeserializeAs(Name = "quantity_list")]
        public string QuantityList { get; set; }

        [DeserializeAs(Name = "sale_amount")]
        public string SaleAmount { get; set; }

        [DeserializeAs(Name = "call_center_call_id")]
        public string CallCenterCallId { get; set; }

        [DeserializeAs(Name = "destination_phone_number")]
        public string DestinationPhoneNumber { get; set; }
    }
}
