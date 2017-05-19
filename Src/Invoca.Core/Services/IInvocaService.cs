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
