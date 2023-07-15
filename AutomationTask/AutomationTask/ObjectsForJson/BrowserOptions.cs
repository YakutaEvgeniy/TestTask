using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
