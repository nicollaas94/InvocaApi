using System;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using System.Net.Http;
using Invoca.Core.Exceptions;
using Invoca.Core.Helpers;
using Invoca.Core.Services;
using Invoca.Core.Client;
using Invoca.Core;

namespace Invoca.Transaction.Client
{
    class InvocaTransactionClient<T> : IInvocaClient<T> where T: new()
    {
        private IInvocaService service;

        internal InvocaTransactionClient(IInvocaService service)
        {
            this.service = service;
        }

        public Result<T> Execute()
        {
            var config = Bootstrap.GetConfig();

            var client = new RestClient(new Uri(config.Url(true), service.Url));

            var request = new RestRequest((RestSharp.Method)service.RequestType);

            if(service.RequestType == Core.Services.Method.GET || service.RequestType == Core.Services.Method.DELETE)
            {
                service.Parameters.GetType().GetProperties().ToList().ForEach(
                    p => 
                    {
                        if(p.GetValue(service.Parameters)!= null)
                            request.AddQueryParameter(p.Name.SnakeCase(), p.GetValue(service.Parameters).ToString());
                    });
                request.AddQueryParameter("oauth_token", config.ApiKey);
            }
            else if(service.RequestType == Core.Services.Method.POST || service.RequestType == Core.Services.Method.PUT)
            {
                request.AddJsonBody(service.Parameters);
            }
            else
            {
                throw new InvocaClientException("Invalid Request Type");
            }

            IRestResponse<T> response = client.Execute<T>(request);
            
            try
            {
                var responseMessage = new HttpResponseMessage(response.StatusCode);
                responseMessage.EnsureSuccessStatusCode();

                return new Result<T> { ObjectResult = response.Data };
            }
            catch (HttpRequestException ex)
            {
                throw new InvocaClientException(response.Content, ex);
            }
            catch
            {
                throw;
            }            
        }

        public async Task<Result<T>> ExecuteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
