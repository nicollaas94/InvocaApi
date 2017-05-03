using System.Threading.Tasks;

namespace Invoca.Core.Client
{
    public interface IInvocaClient<T> where T : new()
    {
        Result<T> Execute();

        Task<Result<T>> ExecuteAsync();
    }
}
