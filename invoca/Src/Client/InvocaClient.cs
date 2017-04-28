using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Invoca.Services;
using RestSharp;
using System.Net.Http;
using Invoca.Exceptions;
using System.Reflection;
using RestSharp.Extensions.MonoHttp;
using Invoca.Helpers;

namespace Invoca.Client
{
    class InvocaClient<T> : IInvocaClient<T> where T: new()
    {
        private IInvocaService service;

        internal InvocaClient(IInvocaService service)
        {
            this.service = service;
        }

        public Result<T> Execute()
        {
            var config = Bootstrap.GetConfig();

            var client = new RestClient(new Uri(config.Url, service.Url));

            var request = new RestRequest(service.RequestType);

            if(service.RequestType == Method.GET || service.RequestType == Method.DELETE)
            {
                service.Parameters.GetType().GetProperties().ToList().ForEach(
                    p => 
                    {
                        if(p.GetValue(service.Parameters)!= null)
                            request.AddQueryParameter(p.Name.SnakeCase(), p.GetValue(service.Parameters).ToString());
                    });
                request.AddQueryParameter("oauth_token", config.ApiKey);
            }
            else if(service.RequestType == Method.POST || service.RequestType == Method.PUT)
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
