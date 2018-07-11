using Newtonsoft.Json;

namespace Ship_Maker.Models {
    public class Equipment {
        [JsonProperty(Order = 0)]
        public string Name { get; private set; }
    }
}