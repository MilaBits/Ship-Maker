using Newtonsoft.Json;

namespace Ship_Maker.Models {
    public class Thrusters : PoweredEquipment {
        
        [JsonProperty(Order = 10)]
        public int ManeuverabilityRating { get; private set; }
        [JsonProperty(Order = 11)]
        public int EngineRating { get; private set; }
        [JsonProperty(Order = 12)]
        public int MaxSpeed { get; private set; }
    }
}