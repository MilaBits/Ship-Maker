using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
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
        private SelectionData selectionData = new SelectionData();


        public MainWindow() {
            mainLogic = new MainLogic(data);
            selectionData.PropertyChanged += UpdateBudgets;

            InitializeComponent();

            BindDataGrids();
        }

        private void UpdateBudgets(object sender, PropertyChangedEventArgs e) {
            LbShipBP.Text = selectionData.MaxBp.ToString();
            LbSpentBP.Text = selectionData.SpentBp.ToString();
            LbTotalBP.Text = selectionData.MaxBp.ToString();
            LbSpentSEA.Text = selectionData.SpentSea.ToString();
            LbTotalSEA.Text = selectionData.MaxSea.ToString();
        }

        private void BindDataGrids() {
            DgPowerCores.ItemsSource = data.PowerCores;
            DgArmor.ItemsSource = data.Armors;
            DgComputers.ItemsSource = data.Computers;
            DgDeployables.ItemsSource = data.Deployables;
            DgShields.ItemsSource = data.Shields;
            DgThrusters.ItemsSource = data.Thrusters;
            DgTransponders.ItemsSource = data.Transponders;
            DgUniqueSystems.ItemsSource = data.UniqueSystems;
            DgUniqueWeapons.ItemsSource = data.UniqueWeapons;
            DgWeapons.ItemsSource = data.PowerCores;
            DgFrames.ItemsSource = data.Frames;

            DgSeats.ItemsSource = data.Seats;
            data.Seats.CollectionChanged += DgSeats_CollectionChanged;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e) {
            mainLogic.GetEquipmentData(data);
        }

        private void btnAddSeat_Click(object sender, RoutedEventArgs e) {
            data.Seats.Add(new Seat() {Role = Role.Pilot, Type = SeatType.Hybrid});
        }

        private void btnRemoveSeat_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Seats: " + data.Seats.Count);
        }

        private void UpdateCrewStatus() {
            RtbSeatStatus.Document.Blocks.Clear();
            RtbSeatStatus.Document.Blocks.Add(data.GetSeatStatus());
        }

        private void DgSeats_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            UpdateCrewStatus();
        }

        private void DgSeats_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e) {
            UpdateCrewStatus();
        }

        private void DgSeats_GotFocus(object sender, RoutedEventArgs e) {
            // Lookup for the source to be DataGridCell
            if (e.OriginalSource.GetType() == typeof(DataGridCell)) {
                // Starts the Edit on the row;
                DataGrid grd = (DataGrid) sender;
                grd.BeginEdit(e);
            }
        }

        private void DgPowerCores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectionData.PowerCore = (PowerCore)((DataGrid)sender).SelectedItem;
        }

        private void DgWeapons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectionData.Weapon = (Weapon)((DataGrid)sender).SelectedItem;
        }

        private void DgDeployables_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectionData.Deployable = (Deployable)((DataGrid)sender).SelectedItem;
        }

        private void DgArmor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectionData.Armor = (Armor)((DataGrid)sender).SelectedItem;
        }

        private void DgUniqueSystems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectionData.UniqueSystem = (UniqueSystem)((DataGrid)sender).SelectedItem;
        }

        private void DgThrusters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectionData.Thrusters = (Thrusters)((DataGrid)sender).SelectedItem;
        }

        private void DgUniqueWeapons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectionData.UniqueWeapon = (UniqueWeapon)((DataGrid)sender).SelectedItem;
        }

        private void DgComputers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectionData.Computer = (Computer)((DataGrid)sender).SelectedItem;
        }

        private void DgFrames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectionData.Frame = (Models.Frame)((DataGrid)sender).SelectedItem;
        }

        private void DgTransponders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectionData.Transponder = (Transponder)((DataGrid)sender).SelectedItem;
        }
    }
}