using Newtonsoft.Json;
using Ship_Maker.Models.Enums;

namespace Ship_Maker.Models {
    public class Weapon : PoweredEquipment {
        
        [JsonProperty(Order = 10)]
        public string Damage { get; private set; }
        [JsonProperty(Order = 11)]
        public DamageType DamageType { get; private set; }
        [JsonProperty(Order = 12)]
        public WeightClass Weightclass { get; private set; }
        [JsonProperty(Order = 13)]
        public string Cards { get; private set; }
    }
}