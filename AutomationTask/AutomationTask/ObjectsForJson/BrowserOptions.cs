using Newtonsoft.Json;

namespace AutomationTask.ObjectsForJson
{
    public class BrowserOptions
    {
        [JsonProperty("browserName")]
        public string BrowserName { get; set; }
        [JsonProperty("lang")]
        public string Language { get; set; }
    }
}
