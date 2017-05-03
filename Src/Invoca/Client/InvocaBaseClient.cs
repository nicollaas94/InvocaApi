using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoca.Client
{
    internal abstract class InvocaBaseClient
    {
        internal RestRequest CreateRequest(IInvocaService service)
        {
            var request = new RestRequest((RestSharp.Method)service.RequestType);

            if (service.RequestType == Core.Services.Method.GET || service.RequestType == Core.Services.Method.DELETE)
            {
                service.Parameters.GetType().GetProperties().ToList().ForEach(
                    p =>
                    {
                        if (p.GetValue(service.Parameters) != null)
                            request.AddQueryParameter(p.Name.SnakeCase(), p.GetValue(service.Parameters).ToString());
                    });
                request.AddQueryParameter("oauth_token", config.ApiKey);
            }
            else if (service.RequestType == Core.Services.Method.POST || service.RequestType == Core.Services.Method.PUT)
            {
                request.AddJsonBody(service.Parameters);
            }
            else
            {
                throw new InvocaClientException("Invalid Request Type");
            }
        }
    }
}
