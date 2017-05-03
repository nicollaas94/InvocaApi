using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Invoca.Core.Services
{
    internal interface IInvocaService
    {
        Method RequestType { get; }

        string Url { get;}

        string Headers { get;}

        object Parameters { get;}
    }

    //
    // Summary:
    //     HTTP method to use when making requests
    public enum Method
    {
        GET = 0,
        POST = 1,
        PUT = 2,
        DELETE = 3,
        HEAD = 4,
        OPTIONS = 5,
        PATCH = 6,
        MERGE = 7
    }
}
