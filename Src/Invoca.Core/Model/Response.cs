using System;

namespace Invoca.Core.Model
{
    public class Response
    {
        /// <summary>
        /// Customer’s street address as given to the call center (first line).
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Customer’s street address as given to the call center (second line).
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// City | Data from caller demographics lookup
        /// </summary>
        public string AddressCityDataAppend { get; set; }

        /// <summary>
        /// Country | Data from caller demographics lookup
        /// </summary>
        public string AddressCountryDataAppend { get; set; }

        /// <summary>
        /// Street Address | Data from caller demographics lookup
        /// </summary>
        public string AddressFullStreetDataAppend { get; set; }

        /// <summary>
        /// State | Data from caller demographics lookup
        /// </summary>
        public string AddressStateDataAppend { get; set; }

        /// <summary>
        /// Address Type | Data from caller demographics lookup
        /// </summary>
        public string AddressTypeDataAppend { get; set; }

        /// <summary>
        /// Zip | Data from caller demographics lookup
        /// </summary>
        public string AddressZipDataAppend { get; set; }

        //RESPONSE START

        /// <summary>
        /// Advertiser Fees | Advertiser Telecommunications fee associated with transaction
        /// </summary>
        public string AdvertiserCallFeeLocalized { get; set; }

        /// <summary>
        /// Advertiser Campaign ID (Invoca ID) | The Invoca identifier of the campaign.
        /// </summary>
        public string AdvertiserCampaignId { get; set; }

        /// <summary>
        /// Advertiser Campaign ID | The Campaign ID from the network as set on the advertiser campaign.
        /// </summary>
        public string AdvertiserCampaignIdFromNetwork { get; set; }

        /// <summary>
        /// Advertiser Campaign	| Name of the campaign.
        /// </summary>
        public string AdvertiserCampaignName { get; set; }

        /// <summary>
        /// Advertiser ID (Invoca ID) |	The Invoca identifier of the advertiser
        /// </summary>
        public string AdvertiserId { get; set; }

        /// <summary>
        /// Advertiser ID | Advertiser ID from the network as set on the Invoca advertiser.
        /// </summary>
        public string AdvertiserIdFromNetwork { get; set; }

        /// <summary>
        /// Advertiser | Name of the advertiser.
        /// </summary>
        public string AdvertiserName { get; set; }

        /// <summary>
        /// Earned	| Amount paid in by advertiser
        /// </summary>
        public string AdvertiserPayinLocalized { get; set; }

        /// <summary>
        /// Affiliate Volume Ranking | Network ranking of affiliate’s call volume (0 to 5, and -1 being ‘new’). Blank if no affiliate.
        /// </summary>
        public string AffiliateCallVolumeRanking { get; set; }

        /// <summary>
        /// Affiliate Commissions Ranking | Network ranking of affiliate’s commissions (0 to 5, and -1 being ‘new’). Blank if no affiliate.
        /// </summary>
        public string AffiliateCommissionsRanking { get; set; }

        /// <summary>
        /// Affiliate Conversion Rate Ranking | Network ranking of affiliate’s conversion rate (0 to 5, and -1 being ‘new’). Blank if no affiliate.
        /// </summary>
        public string AffiliateConversionRateRanking { get; set; }

        /// <summary>
        /// Affiliate ID (Invoca ID) | The Invoca identifier of the affiliate
        /// </summary>
        public string AffiliateId { get; set; }

        /// <summary>
        /// Affiliate ID | Affiliate ID from the network as set on the Invoca affiliate.
        /// </summary>
        public string AffiliateIdFromNetwork { get; set; }

        /// <summary>
        /// Affiliate | Name of the affiliate
        /// </summary>
        public string AffiliateName { get; set; }

        /// <summary>
        /// Paid | Amount paid out to the affiliate
        /// </summary>
        public string AffiliatePayoutLocalized { get; set; }

        //END RESPONSE ---

        // http://developers.invoca.net/en/latest/api_documentation/transactions_api/network_user.html#enhanced-caller-profile-parameters
        /// <summary>
        /// Age Range (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string AgeRangeDataAppend { get; set; }

        // END


        /// <summary>
        /// not found on documentation, but have on return data
        /// </summary>
        public string CallCenterCallId { get; set; }

        /// <summary>
        /// Fees | Telecommunications fee associated with transaction
        /// </summary>
        public string CallFeeLocalized { get; set; }

        /// <summary>
        /// Call Result	| Status of the transaction
        /// </summary>
        public string CallResultDescriptionDetail { get; set; }

        /// <summary>
        /// Source | Source of the transaction
        /// </summary>
        public string CallSourceDescription { get; set; }

        /// <summary>
        /// Caller ID | Caller ID. Formatted as 12 characters like 866-555-1234
        /// </summary>
        public string CallingPhoneNumber { get; set; }

        // --- 

        /// <summary>
        /// Carrier (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string CarrierDataAppend { get; set; }

        /// <summary>
        /// Cell Phone (Reported) | Customer’s cell phone number as given to the call center.
        /// </summary>
        public string CellPhoneNumber { get; set; }

        // ---

        /// <summary>
        /// City | City where transaction originated
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Recording | URL to the call recording, if available
        /// </summary>
        public string Recording { get; set; }

        /// <summary>
        /// Call Record ID |
        /// Globally unique identifier for the call this transaction is part of.
        /// Up-to 32 character string, can contain alphanumeric characters (i.e. 0-9A-Z) and the -.
        /// </summary>
        public string CompleteCallId { get; set; }

        /// <summary>
        /// Connected Duration | Duration in seconds that the call that was connected to the call center.
        /// </summary>
        public int ConnectDuration { get; set; }

        /// <summary>
        /// Corrected At | [Correction only] Date and time the transaction was corrected,
        /// in user’s time zone, followed by offset from GMT.
        /// </summary>
        public string CorrectedAt { get; set; }

        /// <summary>
        /// Corrects Call | [Correction only] Id of the original transaction that this transaction updates.
        /// Values in this row are the corrected ones and should replace the original values. 
        /// Same format as transaction_id. Up-to 32 character string, can contain alphanumeric characters 
        /// (i.e. 0-9A-Z) and the -.
        /// </summary>
        public string CorrectsTransactionId { get; set; }

        /// <summary>
        /// Country (Reported) | Customer’s country as given to the call center.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Destination Phone Number | The phone number where the call was transferred to (useful if an IVR transfers to multiple destinations).
        /// Up-to 20 character string, can contain numeric characters (i.e. 0-9) and the following additional characters: ‘-‘, ‘#’, ‘*’, ‘x’, and ‘,’. ‘
        /// </summary>
        public string DestinationPhoneNumber { get; set; }

        /// <summary>
        /// Display Name (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string DisplayNameDataAppend { get; set; }

        /// <summary>
        /// Total Duration	| Duration of the call in seconds. Includes any time spent in an IVR tree before transferring to the call center.
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Pool ID	| The ID of the pool.
        /// </summary>
        public int DynamicNumberPoolId { get; set; }

        /// <summary>
        /// Pool Type | The type of pool: Search, SearchKeyword or Custom
        /// </summary>
        public string DynamicNumberPoolPoolType { get; set; }

        /// <summary>
        /// AdWords Ad | AdWords Ad Headline copy, provided by Google
        /// </summary>
        public string DynamicNumberPoolReferrerAd { get; set; }

        /// <summary>
        /// AdWords Ad Group | AdWords Ad Group name, provided by Google
        /// </summary>
        public string DynamicNumberPoolReferrerAdGroup { get; set; }

        /// <summary>
        /// AdWords Ad Group ID | AdWords Ad Group ID, provided by Google
        /// </summary>
        public string DynamicNumberPoolReferrerAdGroupId { get; set; }

        /// <summary>
        /// AdWords Ad ID | AdWords Ad ID, provided by Google
        /// </summary>
        public string DynamicNumberPoolReferrerAdId { get; set; }

        /// <summary>
        /// AdWords Keyword Match Type	| The match type for the Keyword
        /// </summary>
        public string DynamicNumberPoolReferrerKeywordMatchType { get; set; }
        
        /// <summary>
        /// Pool Param Name | The name for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam10Name { get; set; }

        /// <summary>
        /// Pool Param Value| The Value for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam10Value { get; set; }

        /// <summary>
        /// Pool Param Name | The name for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam1Name { get; set; }

        /// <summary>
        /// Pool Param Value| The Value for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam1Value { get; set; }

        /// <summary>
        /// Pool Param Value| The Value for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam2Name { get; set; }

        /// <summary>
        /// Pool Param Value| The Value for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam2Value { get; set; }

        /// <summary>
        /// Pool Param Name | The Name for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam3Name { get; set; }

        /// <summary>
        /// Pool Param Value| The Value for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam3Value { get; set; }

        /// <summary>
        /// Pool Param Name | The Name for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam4Name { get; set; }

        /// <summary>
        /// Pool Param Value| The Value for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam4Value { get; set; }

        /// <summary>
        /// Pool Param Name | The Name for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam5Name { get; set; }

        /// <summary>
        /// Pool Param Value| The Value for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam5Value { get; set; }

        /// <summary>
        /// Pool Param Name | The Name for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam6Name { get; set; }

        /// <summary>
        /// Pool Param Value| The Value for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam6Value { get; set; }

        /// <summary>
        /// Pool Param Name | The Name for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam7Name { get; set; }

        /// <summary>
        /// Pool Param Value| The Value for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam7Value { get; set; }

        /// <summary>
        /// Pool Param Name | The Name for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam8Name { get; set; }

        /// <summary>
        /// Pool Param Value| The Value for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam8Value { get; set; }

        /// <summary>
        /// Pool Param Name | The Name for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam9Name { get; set; }

        /// <summary>
        /// Pool Param Value| The Value for parameter
        /// </summary>
        public string DynamicNumberPoolReferrerParam9Value { get; set; }

        /// <summary>
        /// AdWords Campaign | AdWords Campaign name, provided by Google
        /// </summary>
        public string DynamicNumberPoolReferrerReferrerCampaign { get; set; }

        /// <summary>
        /// AdWords Campaign ID | AdWords Campaign ID, provided by Google
        /// </summary>
        public string DynamicNumberPoolReferrerReferrerCampaignId { get; set; }

        /// <summary>
        /// Traffic Source | Search engine used.
        /// </summary>
        public string DynamicNumberPoolReferrerSearchEngine { get; set; }

        /// <summary>
        /// Keywords | Search keywords used
        /// </summary>
        public string DynamicNumberPoolReferrerSearchKeywords { get; set; }

        /// <summary>
        /// AdWords Keywords ID | AdWords Keyword ID, provided by Google
        /// </summary>
        public string DynamicNumberPoolReferrerSearchKeywordsId { get; set; }

        /// <summary>
        /// Search Type	| Paid or Organic.
        /// </summary>
        public string DynamicNumberPoolReferrerSearchType { get; set; }

        /// <summary>
        /// Education (Data Append)	| Data from caller demographics lookup
        /// </summary>
        public string EducationDataAppend { get; set; }

        /// <summary>
        /// Email Address (Reported) | Email address as given to the call center.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// First Name (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string FirstNameDataAppend { get; set; }

        /// <summary>
        /// Gender (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string GenderDataAppend { get; set; }

        /// <summary>
        /// End of Call Reason | Who ended the call along with how it was ended
        /// </summary>
        public string HangupCause { get; set; }

        /// <summary>
        /// Has Children (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string HasChildrenDataAppend { get; set; }

        /// <summary>
        /// High Net Worth (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string HighNetWorthDataAppend { get; set; }

        /// <summary>
        /// Home Market Value (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string HomeMarketValueDataAppend { get; set; }

        /// <summary>
        /// Home Owner Status (Data Append)	Data from caller demographics lookup
        /// </summary>
        public string HomeOwnerStatusDataAppend { get; set; }

        /// <summary>
        /// Home Phone (Reported) | Customer’s home phone number as given to the call center.
        /// </summary>
        public string HomePhoneNumber { get; set; }

        /// <summary>
        /// Household Income (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string HouseholdIncomeDataAppend { get; set; }

        /// <summary>
        /// Is Prepaid (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string IsPrepaidDataAppend { get; set; }

        /// <summary>
        /// IVR Duration | Duration in seconds that the call spent in the IVR tree.
        /// </summary>
        public int IvrDuration { get; set; }

        /// <summary>
        /// Key Name of the key that was pressed
        /// </summary>
        public string Keypress1 { get; set; }

        /// <summary>
        /// Key Name of the key that was pressed
        /// </summary>
        public string Keypress2 { get; set; }

        /// <summary>
        /// Key Name of the key that was pressed
        /// </summary>
        public string Keypress3 { get; set; }

        /// <summary>
        /// Key Name of the key that was pressed
        /// </summary>
        public string Keypress4 { get; set; }

        /// <summary>
        /// Keypresses	List of unique keynames that were pressed during the call
        /// </summary>
        public string Keypresses { get; set; }

        /// <summary>
        /// Last Name (Data Append)	Data from caller demogra
        /// </summary>
        public string LastNameDataAppend { get; set; }

        /// <summary>
        /// Length of Residence in Years (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string LengthOfResidenceYearsDataAppend { get; set; }

        /// <summary>
        /// Line Type (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string LineTypeDataAppend { get; set; }

        /// <summary>
        /// Linked Email Addresses (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string LinkedEmailAddressesDataAppend { get; set; }

        /// <summary>
        /// Margin | Difference between advertiser_payin_localized and affiliate_payout_localized
        /// </summary>
        public string MarginLocalized { get; set; }

        /// <summary>
        /// Marital Status (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string MaritalStatusDataAppend { get; set; }

        /// <summary>
        /// Matching Advertiser Payin Policies	| 
        /// List of advertiser policies that matched (base, bonus1, bonus2, etc.) to determine the advertiser payin, separated by +. 
        /// For example, base+bonus1+bonus3. Note that if there was any advertiser payin, this field guaranteed to start with base.
        /// </summary>
        public string MatchingAdvertiserPayinPolicies { get; set; }

        /// <summary>
        /// Matching Affiliate Payout Policies	List of affiliate policies that matched (base, bonus1, bonus2, etc.) to determine the affiliate payout, separated by +.
        /// For example, base+bonus2. Note that if there was any affiliate payout, this field guaranteed to start with base.
        /// </summary>
        public string MatchingAffiliatePayoutPolicies { get; set; }

        /// <summary>
        /// Media Type	Media type of the transaction source
        /// </summary>
        public string MediaType { get; set; }

        /// <summary>
        /// Phone Type | Landline or Mobile or empty string if type is unknown
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Name (Reported)	| Customer’s full name as given to the call center.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Notes	Free-form notations on transaction
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Occupation (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string OccupationDataAppend { get; set; }

        /// <summary>
        /// Opt In Sms	Whether the caller opted in to receive an SMS promotion.
        /// </summary>
        public int OptInSMS { get; set; }

        /// <summary>
        /// City (Reported)	Customer’s city as given to the call center.
        /// </summary>
        public string OrderCity { get; set; }

        /// <summary>
        /// Order ID | [Sales reporting only] Id of the original transaction that this row is in reference to.
        /// Up-to 32 character string, can contain alphanumeric characters (i.e. 0-9A-Z) and the -.
        /// </summary>
        public string OriginalOrderId { get; set; }

        /// <summary>
        /// Payin Conditions | Base condition with highlighting around the term(s) that disqualified advertiser payin.
        /// For example: duration > 1 min and in_region
        /// </summary>
        public string PayinConditions { get; set; }

        /// <summary>
        /// Payout Conditions | Base condition with highlighting around the term(s) that disqualified affiliate payout.
        /// For example: duration > 1 min and in_region
        /// </summary>
        public string PayoutConditions { get; set; }

        /// <summary>
        /// Primary Email Address (Data Append) | Data from caller demographics lookup
        /// </summary>
        public string PrimaryEmailAddressDataAppend { get; set; }

        /// <summary>
        /// Promo Number Description | Additional details about the transaction source
        /// </summary>
        public string PromoLineDescription { get; set; }

        /// <summary>
        /// Qualified Regions | The list of regions that that the caller matched
        /// </summary>
        public string QualifiedRegions { get; set; }

        /// <summary>
        /// Quantity List | Comma-separated list of order quantities as reported by the call center.
        /// Each quantity in the list matches the sku_list entry in that same position.
        /// </summary>
        public string QuantityList { get; set; }

        /// <summary>
        /// Region	Region (state, province or country) | where transaction originated
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Repeat Caller | Whether the call was a repeat call. Repeat call detection is not applied to shared or unavailable caller ids.
        /// </summary>
        public string RepeatCallingPhoneNumber { get; set; }

        /// <summary>
        /// not documented
        /// </summary>
        public string Revenue { get; set; }

        /// <summary>
        /// Sale Amount | Total order amount (not including shipping) as reported by the call center.
        /// </summary>
        public string SaleAmount { get; set; }

        /// <summary>
        /// Signal Custom Param | Up to 255 character string.
        /// </summary>
        public string SignalCustomParameter1 { get; set; }

        /// <summary>
        /// Signal Custom Param | Up to 255 character string.
        /// </summary>
        public string SignalCustomParameter2 { get; set; }

        /// <summary>
        /// Signal Custom Param | Up to 255 character string.
        /// </summary>
        public string SignalCustomParameter3 { get; set; }

        /// <summary>
        /// Signal Description	Free form text for providing additional details about the signal.
        /// </summary>
        public string SignalDescription { get; set; }

        /// <summary>
        /// Signal Name	The name describing the signal event.
        /// </summary>
        public string SignalName { get; set; }

        /// <summary>
        /// Signal Occurred At | 10 digit time that the signal occurred, in UTC seconds since 1/1/70, also known as Unix time_t.
        /// </summary>
        public string SignalOccurredAt { get; set; }

        /// <summary>
        /// Signal Partner ID | Unique identifier, to distinguish between updating an existing signal 
        /// (for example correcting a sale that was reported) 
        /// versus adding a second sale to the call 
        /// (for example a reservation made while on the call and then an add on item purchased later).
        /// </summary>
        public string SignalPartnerUniqueId { get; set; }

        /// <summary>
        /// Signal Source | The source of the signal. Possible values are :UserOverride, :Api, :Import, :Expression, :Ivr, and :Machine
        /// </summary>
        public string SignalSource { get; set; }

        /// <summary>
        /// Signal Value | True or false as to whether or not the signal was met and null if it is not a signal transaction.
        /// </summary>
        public string SignalValue { get; set; }

        /// <summary>
        /// SKU List | Comma-separated list of order SKUs as reported by the call center.
        /// </summary>
        public string SkuList { get; set; }

        /// <summary>
        /// Call Start Time	| Start of the call in the API user’s time zone, followed by offset from GMT.
        /// </summary>
        public string StartTimeLocal { get; set; }

        /// <summary>
        /// Call Start Time Network Timezone | Start of the call in the networks’s time zone, followed by offset from GMT.
        /// </summary>
        public string StartTimeNetworkTimezone { get; set; }

        /// <summary>
        /// Call Start Time Network Timezone (XML formatted) | Start of the call in the network’s time zone in Soap XML formatted time.
        /// </summary>
        public DateTime StartTimeNetworkTimezoneXml { get; set; }

        /// <summary>
        /// Call Start Time (UTC timestamp)	| Start of the call in milliseconds since Jan 1, 1970. Divide by 1000 to get Unix epoch time.
        /// </summary>
        public string StartTimeUtc { get; set; }

        /// <summary>
        /// Call Start Time (XML formatted)	| Start of the call in the API user’s time zone in Soap XML formatted time.
        /// </summary>
        public DateTime StartTimeXml { get; set; }

        /// <summary>
        /// State or Province (Reported)	Customer’s state or province as given to the call center.
        /// </summary>
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Transaction ID | Globally unique identifier for this transaction.
        /// Up-to 32 character string, can contain alphanumeric characters (i.e. 0-9A-Z) and the -.
        /// This is the Primary Key of the results.
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// Type | The type of transaction - Call, Reported Conversion or Signal.
        /// </summary>
        public string TransactionType { get; set; }

        /// <summary>
        /// Transfer Type | Where the call came from
        /// </summary>
        public string TransferFromType { get; set; }

        /// <summary>
        /// Verified Zip Code | Zip Code entered by callers when prompted during call treatment
        /// </summary>
        public string VerifiedZip { get; set; }

        /// <summary>
        /// Promo Number ID | The Promo Number ID from the network
        /// </summary>
        public string VirtualLineId { get; set; }

        /// <summary>
        /// Customer’s zip code as given to the call center.
        /// </summary>
        public string ZipCode { get; set; }
    }
}
