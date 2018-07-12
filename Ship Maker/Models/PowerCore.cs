using Newtonsoft.Json;
using Ship_Maker.Models.Enums;

namespace Ship_Maker.Models {
    public class PowerCore : PoweredEquipment {
        
        [JsonProperty(Order = 10)]
        public int SEA { get; private set; }
        [JsonProperty(Order = 11)]
        public int StrainThreshold { get; private set; }
        [JsonProperty(Order = 12)]
        public StrainReduction StrainReduction { get; private set; }
    }
}
