using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using Ship_Maker.Models.Enums;

namespace Ship_Maker.Models {
    public class Data {
        public ObservableCollection<PowerCore> PowerCores = new ObservableCollection<PowerCore>();
        public ObservableCollection<Armor> Armors = new ObservableCollection<Armor>();
        public ObservableCollection<Thrusters> Thrusters = new ObservableCollection<Thrusters>();
        public ObservableCollection<Computer> Computers = new ObservableCollection<Computer>();
        public ObservableCollection<Transponder> Transponders = new ObservableCollection<Transponder>();
        public ObservableCollection<Weapon> Weapons = new ObservableCollection<Weapon>();
        public ObservableCollection<Shield> Shields = new ObservableCollection<Shield>();
        public ObservableCollection<Deployable> Deployables = new ObservableCollection<Deployable>();
        public ObservableCollection<UniqueSystem> UniqueSystems = new ObservableCollection<UniqueSystem>();
        public ObservableCollection<UniqueWeapon> UniqueWeapons = new ObservableCollection<UniqueWeapon>();

        public ObservableCollection<Frame> Frames = new ObservableCollection<Frame>();

        public ObservableCollection<Seat> Seats = new ObservableCollection<Seat>();

        public Paragraph GetSeatStatus() {
            int pilots, gunners, captains, scienceOfficers, mages, engineers;
            pilots = gunners = captains = scienceOfficers = mages = engineers = 0;

            // Count each role
            foreach (Seat seat in Seats) {
                switch (seat.Role) {
                    case Role.Pilot:
                        pilots++;
                        break;
                    case Role.Gunner:
                        gunners++;
                        break;
                    case Role.Captain:
                        captains++;
                        break;
                    case Role.Mage:
                        mages++;
                        break;
                    case Role.ScienceOfficer:
                        scienceOfficers++;
                        break;
                    case Role.Engineer:
                        engineers++;
                        break;
                }
            }

            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(new Bold(new Run("C ")));
            paragraph.Inlines.Add(new Run(captains + "; "));
            paragraph.Inlines.Add(new Bold(new Run("P ")));
            paragraph.Inlines.Add(new Run(pilots + "; "));
            paragraph.Inlines.Add(new Bold(new Run("G ")));
            paragraph.Inlines.Add(new Run(gunners + "; "));
            paragraph.Inlines.Add(new Bold(new Run("E ")));
            paragraph.Inlines.Add(new Run(engineers + "; "));
            paragraph.Inlines.Add(new Bold(new Run("S ")));
            paragraph.Inlines.Add(new Run(scienceOfficers + "; "));
            paragraph.Inlines.Add(new Bold(new Run("M ")));
            paragraph.Inlines.Add(new Run(mages.ToString()));

            return paragraph;
        }
    }
}