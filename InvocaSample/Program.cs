using Invoca.Model;

namespace InvocaSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoca.Bootstrap.Start(new Invoca.InvocaApiConfig()
            {
                ApiKey = "INVOCA_API_KEY_HERE",
                NetworkId = 33, // INVOCA NETWORKID HERE
                AdvertiserId = 33,
                AffiliateId = 33,
                Subdomain = "mynetwork",
                Mode = Invoca.InvocaApiMode.Production
            });

            var param = new QueryParameters();
            param.SetExcludeColumns("calling_phone_number", "recording");
            param.SetLimit(50);
            var network = new Invoca.Services.NetworksService().GetNetwork(param).Execute().ObjectResult;
            var advertiser = new Invoca.Services.AdvertiserService().GetAdvertiser(param).Execute().ObjectResult;
            var affiliate = new Invoca.Services.AffiliateService().GetAffiliate(param).Execute().ObjectResult;
        }
    }
}
