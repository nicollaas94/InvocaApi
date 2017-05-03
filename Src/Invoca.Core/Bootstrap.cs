using Invoca.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
