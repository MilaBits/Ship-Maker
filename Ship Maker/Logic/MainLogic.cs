using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Ship_Maker.Models;
using Ship_Maker.Models.Enums;

namespace Ship_Maker.Logic {
    public class MainLogic {
        
        private readonly string dataPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "/Data/");
        
        public MainLogic(Data data) {
            if (!Directory.Exists(dataPath)) {
                Directory.CreateDirectory(dataPath);
                GenerateBaseJsonFiles();
            }

            data.PowerCores = LoadEquipment<PowerCore>("PowerCores.json");
            data.Armors = LoadEquipment<Shield>("Armors.json");
            data.Thrusters = LoadEquipment<Thrusters>("Thrusters.json");
            data.Computers = LoadEquipment<Computer>("Computers.json");
            data.Transponders = LoadEquipment<Transponder>("Transponders.json");
            data.Weapons = LoadEquipment<Weapon>("Weapons.json");
            data.Deployables = LoadEquipment<Deployable>("Deployables.json");
            data.UniqueWeapons = LoadEquipment<UniqueWeapon>("UniqueWeapons.json");
            data.UniqueSystems = LoadEquipment<UniqueSystem>("UniqueSystems.json");
        }
        
        private List<T> LoadEquipment<T>(string filename) {
            string filePath = dataPath + filename;
            MakeSureFileExists(filePath);

            string json = File.ReadAllText(filePath);
            
            List<T> equipment = JsonConvert.DeserializeObject<List<T>>(json);
            return equipment;
        }

        private void MakeSureFileExists(string path) {
            if (!Directory.Exists(dataPath)) {
                Directory.CreateDirectory(dataPath);
            }
        }

        // Just to create initial files
        private void GenerateJsonFile(object generateObject, string filename) {
            string filePath = dataPath + filename;

            MakeSureFileExists(filePath);
            using (FileStream fs = File.Create(filePath)) {
                byte[] bytes = new UTF8Encoding(true).GetBytes(JsonConvert.SerializeObject(generateObject));
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        private void GenerateBaseJsonFiles() {
            List<PowerCore> GeneratePowerCores = new List<PowerCore>();
            GeneratePowerCores.Add(new PowerCore());
            GenerateJsonFile(GeneratePowerCores, "PowerCores.json");
            
            List<Thrusters> GenerateThrusters = new List<Thrusters>();
            GenerateThrusters.Add(new Thrusters());
            GenerateJsonFile(GenerateThrusters, "Thrusters.json");
            
            List<Shield> GenerateShields = new List<Shield>();
            GenerateShields.Add(new Shield());
            GenerateJsonFile(GenerateShields, "Shields.json");
            
            List<Computer> GenerateComputers = new List<Computer>();
            GenerateComputers.Add(new Computer());
            GenerateJsonFile(GenerateComputers, "Computers.json");
            
            List<Transponder> GenerateTransponders = new List<Transponder>();
            GenerateTransponders.Add(new Transponder());
            GenerateJsonFile(GenerateTransponders, "Transponders.json");
            
            List<Weapon> GenerateWeapons = new List<Weapon>();
            GenerateWeapons.Add(new Weapon());
            GenerateJsonFile(GenerateWeapons, "Weapons.json");
            
            List<Deployable> GenerateDeployables = new List<Deployable>();
            GenerateDeployables.Add(new Deployable());
            GenerateJsonFile(GenerateDeployables, "Deployables.json");
            
            List<UniqueSystem> GenerateUniqueSystems = new List<UniqueSystem>();
            GenerateUniqueSystems.Add(new UniqueSystem());
            GenerateJsonFile(GenerateUniqueSystems, "UniqueSystems.json");
            
            List<UniqueWeapon> GenerateUniqueWeapons = new List<UniqueWeapon>();
            GenerateUniqueWeapons.Add(new UniqueWeapon());
            GenerateJsonFile(GenerateUniqueWeapons, "UniqueWeapons.json");
            
            List<Armor> GenerateArmors = new List<Armor>();
            GenerateArmors.Add(new Armor());
            GenerateJsonFile(GenerateArmors, "Armors.json");
        }
    }
}