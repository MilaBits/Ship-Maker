using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Ship_Maker.Models;
using Ship_Maker.Models.Enums;

namespace Ship_Maker.Logic {
    public class MainLogic {
        private readonly string dataPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + "/Data/");

        public MainLogic(Data data) {
            GetEquipmentData(data);
        }

        public void GetEquipmentData(Data data) {
            // Make sure data directory exists
            if (!Directory.Exists(dataPath)) {
                Directory.CreateDirectory(dataPath);
            }
            
            // Make sure there's at least empty lists to read from.
            GenerateBaseJsonFiles();

            data.PowerCores.Clear();
            data.PowerCores.AddRange(LoadEquipment<PowerCore>("PowerCores.json"));

            data.Armors.Clear();
            data.Armors.AddRange(LoadEquipment<Armor>("Armors.json"));

            data.Thrusters.Clear();
            data.Thrusters.AddRange(LoadEquipment<Thrusters>("Thrusters.json"));

            data.Computers.Clear();
            data.Computers.AddRange(LoadEquipment<Computer>("Computers.json"));

            data.Transponders.Clear();
            data.Transponders.AddRange(LoadEquipment<Transponder>("Transponders.json"));

            data.Weapons.Clear();
            data.Weapons.AddRange(LoadEquipment<Weapon>("Weapons.json"));

            data.Deployables.Clear();
            data.Deployables.AddRange(LoadEquipment<Deployable>("Deployables.json"));

            data.UniqueWeapons.Clear();
            data.UniqueWeapons.AddRange(LoadEquipment<UniqueWeapon>("UniqueWeapons.json"));

            data.UniqueSystems.Clear();
            data.UniqueSystems.AddRange(LoadEquipment<UniqueSystem>("UniqueSystems.json"));
            
            data.Frames.Clear();
            data.Frames.AddRange(LoadEquipment<Frame>("Frames.json"));
        }

        private ObservableCollection<T> LoadEquipment<T>(string filename) {
            string filePath = dataPath + filename;
            MakeSureFileExists(filePath);

            string json = File.ReadAllText(filePath);

            ObservableCollection<T> equipment = JsonConvert.DeserializeObject<ObservableCollection<T>>(json);
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
            if (!File.Exists(dataPath + "PowerCores.json")) {
                List<PowerCore> GeneratePowerCores = new List<PowerCore>();
                GeneratePowerCores.Add(new PowerCore());
                GenerateJsonFile(GeneratePowerCores, "PowerCores.json");
            }

            if (!File.Exists(dataPath + "Thrusters.json")) {
                List<Thrusters> GenerateThrusters = new List<Thrusters>();
                GenerateThrusters.Add(new Thrusters());
                GenerateJsonFile(GenerateThrusters, "Thrusters.json");
            }

            if (!File.Exists(dataPath + "Shields.json")) {
                List<Shield> GenerateShields = new List<Shield>();
                GenerateShields.Add(new Shield());
                GenerateJsonFile(GenerateShields, "Shields.json");
            }

            if (!File.Exists(dataPath + "Computers.json")) {
                List<Computer> GenerateComputers = new List<Computer>();
                GenerateComputers.Add(new Computer());
                GenerateJsonFile(GenerateComputers, "Computers.json");
            }

            if (!File.Exists(dataPath + "Transponders.json")) {
                List<Transponder> GenerateTransponders = new List<Transponder>();
                GenerateTransponders.Add(new Transponder());
                GenerateJsonFile(GenerateTransponders, "Transponders.json");
            }

            if (!File.Exists(dataPath + "Weapons.json")) {
                List<Weapon> GenerateWeapons = new List<Weapon>();
                GenerateWeapons.Add(new Weapon());
                GenerateJsonFile(GenerateWeapons, "Weapons.json");
            }

            if (!File.Exists(dataPath + "Deployables.json")) {
                List<Deployable> GenerateDeployables = new List<Deployable>();
                GenerateDeployables.Add(new Deployable());
                GenerateJsonFile(GenerateDeployables, "Deployables.json");
            }

            if (!File.Exists(dataPath + "UniqueSystems.json")) {
                List<UniqueSystem> GenerateUniqueSystems = new List<UniqueSystem>();
                GenerateUniqueSystems.Add(new UniqueSystem());
                GenerateJsonFile(GenerateUniqueSystems, "UniqueSystems.json");
            }

            if (!File.Exists(dataPath + "UniqueWeapons.json")) {
                List<UniqueWeapon> GenerateUniqueWeapons = new List<UniqueWeapon>();
                GenerateUniqueWeapons.Add(new UniqueWeapon());
                GenerateJsonFile(GenerateUniqueWeapons, "UniqueWeapons.json");
            }

            if (!File.Exists(dataPath + "Armors.json")) {
                List<Armor> GenerateArmors = new List<Armor>();
                GenerateArmors.Add(new Armor());
                GenerateJsonFile(GenerateArmors, "Armors.json");
            }

            // Other stuff
            if (!File.Exists(dataPath + "Frames.json")) {
                List<Frame> GenerateFramees = new List<Frame>();
                GenerateFramees.Add(new Frame());
                GenerateJsonFile(GenerateFramees, "Frames.json");
            }
        }
    }
}