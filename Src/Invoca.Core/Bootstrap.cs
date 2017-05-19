using Invoca.Core.Exceptions;

namespace Invoca.Core
{
    public class Bootstrap
    {
        protected static InvocaApiConfig config;

        public static void Start(InvocaApiConfig config)
        {
            Bootstrap.config = config;
        }

        public static InvocaApiConfig GetConfig()
        {
            if(config == null)
            {
                throw new BootstrapException("First call start");
            }
            return config;
        }
    }
}
