using Newtonsoft.Json;

namespace Ship_Maker.Models {
    public class Shield : PoweredEquipment {
        
        [JsonProperty(Order = 10)]
        public int ShieldPoints { get; private set; }
        [JsonProperty(Order = 11)]
        public int ShieldAC { get; private set; }
        [JsonProperty(Order = 12)]
        public int shieldRegen { get; private set; }
    }
}