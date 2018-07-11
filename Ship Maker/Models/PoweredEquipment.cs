using Newtonsoft.Json;

namespace Ship_Maker.Models {
    public class PoweredEquipment : Equipment {
        [JsonProperty(Order = 1)]
        public int BPCost { get; private set; }
        [JsonProperty(Order = 2)]
        public int SEACost { get; private set; }
        [JsonProperty(Order = 20)]
        public string Rules { get; private set; }
    }
}