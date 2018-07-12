using System.ComponentModel;
using Ship_Maker.Models.Enums;

namespace Ship_Maker.Models {
    public class SelectionData : INotifyPropertyChanged {

        private int _maxBp = 0;
        public int MaxBp { get; set; }
        private int _bp = 0;
        public int SpentBp { get; set; }

        private int _maxSea = 0;
        public int MaxSea { get; set; }
        private int _sea = 0;
        public int SpentSea { get; set; }

        private Frame _frame = new Frame();
        public Frame Frame {
            get => _frame;
            set {
                if (value != _frame) {
                    SpentBp -= _frame.BPCost;
                    _frame = value;
                    SpentBp += _frame.BPCost;
                    OnPropertyChanged("Frame");
                }
            }
        }

        private PowerCore _powerCore = new PowerCore();
        public PowerCore PowerCore {
            get => _powerCore;
            set {
                if (value != _powerCore) {
                    SpentBp -= _powerCore.BPCost;
                    SpentSea -= _powerCore.SEACost;
                    MaxSea -= _powerCore.SEA;
                    _powerCore = value;
                    SpentBp += _powerCore.BPCost;
                    SpentSea += _powerCore.SEACost;
                    MaxSea += _powerCore.SEA;
                    OnPropertyChanged("PowerCore");
                }
            }
        }

        private Armor _armor = new Armor();
        public Armor Armor {
            get => _armor;
            set {
                if (value != _armor) {
                    SpentBp -= _armor.BPCost;
                    SpentSea -= _armor.SEACost;
                    _armor = value;
                    SpentBp += _armor.BPCost;
                    SpentSea += _armor.SEACost;
                    OnPropertyChanged("Armor");
                }
            }
        }

        private Shield _shield = new Shield();
        public Shield Shield {
            get => _shield;
            set {
                if (value != _shield) {
                    SpentBp -= _shield.BPCost;
                    SpentSea -= _shield.SEACost;
                    _shield = value;
                    SpentBp += _shield.BPCost;
                    SpentSea += _shield.SEACost;
                    OnPropertyChanged("Shield");
                }
            }
        }

        private Thrusters _thrusters = new Thrusters();
        public Thrusters Thrusters {
            get => _thrusters;
            set {
                if (value != _thrusters) {
                    SpentBp -= _thrusters.BPCost;
                    SpentSea -= _thrusters.SEACost;
                    _thrusters = value;
                    SpentBp += _thrusters.BPCost;
                    SpentSea += _thrusters.SEACost;
                    OnPropertyChanged("Thrusters");
                }
            }
        }

        private Computer _computer = new Computer();
        public Computer Computer {
            get => _computer;
            set {
                if (value != _computer) {
                    SpentBp -= _computer.BPCost;
                    SpentSea -= _computer.SEACost;
                    _computer = value;
                    SpentBp += _computer.BPCost;
                    SpentSea += _computer.SEACost;

                    OnPropertyChanged("Computer");
                }
            }
        }

        private Transponder _transponder = new Transponder();
        public Transponder Transponder {
            get => _transponder;
            set {
                if (value != _transponder) {
                    SpentBp -= _transponder.BPCost;
                    SpentSea -= _transponder.SEACost;
                    _transponder = value;
                    SpentBp += _transponder.BPCost;
                    SpentSea += _transponder.SEACost;

                    OnPropertyChanged("Transponder");
                }
            }
        }

        private Weapon _weapon = new Weapon();
        public Weapon Weapon {
            get => _weapon;
            set {
                if (value != _weapon) {
                    SpentBp -= _weapon.BPCost;
                    SpentSea -= _weapon.SEACost;
                    _weapon = value;
                    SpentBp += _weapon.BPCost;
                    SpentSea += _weapon.SEACost;

                    OnPropertyChanged("Weapon");
                }
            }
        }

        private Deployable _deployable = new Deployable();
        public Deployable Deployable {
            get => _deployable;
            set {
                if (value != _deployable) {
                    SpentBp -= _deployable.BPCost;
                    SpentSea -= _deployable.SEACost;
                    _deployable = value;
                    SpentBp += _deployable.BPCost;
                    SpentSea += _deployable.SEACost;

                    OnPropertyChanged("Deployable");
                }
            }
        }

        private UniqueWeapon _uniqueWeapon = new UniqueWeapon();
        public UniqueWeapon UniqueWeapon {
            get => _uniqueWeapon;
            set {
                if (value != _uniqueWeapon) {
                    _uniqueWeapon = value;
                    OnPropertyChanged("UniqueWeapon");
                }
            }
        }

        private UniqueSystem _uniqueSystem = new UniqueSystem();
        public UniqueSystem UniqueSystem {
            get => _uniqueSystem;
            set {
                if (value != _uniqueSystem) {
                    _uniqueSystem = value;
                    OnPropertyChanged("UniqueSystem");
                }
            }
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs e) {
            PropertyChanged?.Invoke(this, e);
        }

        protected void OnPropertyChanged(string propertyName) {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}