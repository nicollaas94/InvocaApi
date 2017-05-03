using Invoca.Core;
using Invoca.Core.Model;
using Invoca.Network.Services;
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
            //var service = new TransactionService();
            //var network = service.GetNetwork(param).Execute().ObjectResult;
            //var advertiser = service.GetAdvertiser(param).Execute().ObjectResult;
            //var affiliate = service.GetAffiliate(param).Execute().ObjectResult;
            var service = new AdvertiserCampaignsService();
            var result = service.GetCampaingsForAdvertiser(33).Execute().ObjectResult;

        }
    }
}
