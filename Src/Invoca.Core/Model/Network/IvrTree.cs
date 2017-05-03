namespace Invoca.Core.Model.Network
{
    public class IvrTree
    {
        public bool RecordCalls { get; set; }
        public string CustomChallengePromptText { get; set; }
        public string CustomChallengePromptIdFromNetwork { get; set; }
        public Root Root { get; set; }
    }
}