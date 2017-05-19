namespace Invoca.Core.Model.Network.Advertiser.Campaigns
{
    public class IvrTree
    {
        public bool RecordCalls { get; set; }
        public string CustomChallengePromptText { get; set; }
        public string CustomChallengePromptIdFromNetwork { get; set; }
        public Root Root { get; set; }
    }
}