using System.Collections.Generic;

namespace Invoca.Core.Model.Network
{
    public class Root
    {
        public string Condition { get; set; }
        public List<Child> Children { get; set; }
        public string NodeType { get; set; }
        public string DestinationPhoneNumber { get; set; }
        public string DestinationCountryCode { get; set; }
        public string DestinationExtension { get; set; }
        public string Prompt { get; set; }
        public string PromptIdFromNetwork { get; set; }
        public string PromptUrl { get; set; }
        public string PromptReceived { get; set; }
    }
}