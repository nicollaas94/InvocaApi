using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Invoca.Services
{
    internal interface IInvocaService
    {
        Method RequestType { get; }

        string Url { get;}

        string Headers { get;}

        object Parameters { get;}
    }  
}
