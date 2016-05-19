using Newtonsoft.Json;

namespace BambooTray.Domain.Resources
{
    // ReSharper disable ClassNeverInstantiated.Global
    // ReSharper disable UnusedAutoPropertyAccessor.Global
    public class Plans
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("max-result")]
        public int MaxResult { get; set; }

        [JsonProperty("start-index")]
        public int StartIndex { get; set; }

        [JsonProperty("plan")]
        public PlanDetailResonse[] Plan { get; set; }
    }
}