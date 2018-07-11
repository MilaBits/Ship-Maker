using System.Collections.Generic;
using Ship_Maker.Logic;
using Ship_Maker.Models;
using Ship_Maker.Models.Enums;

namespace Ship_Maker {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        
        private MainLogic mainLogic;
        private Data data = new Data();
        
        public MainWindow() {

            mainLogic = new MainLogic(data);

            
            InitializeComponent();

            BindDataGrids();
        }

        private void BindDataGrids() {
            dgPowerCores.ItemsSource = data.PowerCores;
            dgArmor.ItemsSource = data.Armors;
            dgComputers.ItemsSource = data.Computers;
            dgDeployables.ItemsSource = data.Deployables;
            dgShields.ItemsSource = data.Shields;
            dgThrusters.ItemsSource = data.Thrusters;
            dgTransponders.ItemsSource = data.Transponders;
            dgUniqueSystems.ItemsSource = data.UniqueSystems;
            dgUniqueWeapons.ItemsSource = data.UniqueWeapons;
            dgWeapons.ItemsSource = data.PowerCores;
        }
    }
}