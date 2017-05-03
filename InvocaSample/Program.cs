using Invoca.Core;
using Invoca.Core.Model;
using Invoca.Transaction.Services;

namespace InvocaSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrap.Start(new InvocaApiConfig()
            {
                ApiKey = "INVOCA_API_KEY_HERE",
                NetworkId = 33, // INVOCA NETWORKID HERE
                AdvertiserId = 33,
                AffiliateId = 33,
                Subdomain = "mynetwork",
                Mode = Invoca.Core.InvocaApiMode.Production
            });

            var param = new QueryParameters();
            param.SetExcludeColumns("calling_phone_number", "recording");
            param.SetLimit(50);
            var network = new NetworksService().GetNetwork(param).Execute().ObjectResult;
            var advertiser = new AdvertiserService().GetAdvertiser(param).Execute().ObjectResult;
            var affiliate = new AffiliateService().GetAffiliate(param).Execute().ObjectResult;
        }
    }
}
