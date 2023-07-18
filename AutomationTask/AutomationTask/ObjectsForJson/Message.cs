using Newtonsoft.Json;

namespace AutomationTask.ObjectsForJson
{
    public class Message
    {
        [JsonProperty("morningMessage")]
        public string MorningMessage { get; set; }
        [JsonProperty("dayMessage")]
        public string DayMessage { get; set; }
        [JsonProperty("eveningMessage")]
        public string EveningMessage { get; set; }
        [JsonProperty("nightMessage")]
        public string NightMessage { get; set; }
    }
}
