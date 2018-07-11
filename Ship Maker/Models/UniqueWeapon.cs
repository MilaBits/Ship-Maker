using Newtonsoft.Json;

namespace Ship_Maker.Models {
    public class UniqueWeapon : Equipment {
        
        [JsonProperty(Order = 10)]
        public string Cards { get; private set; }
    }
}