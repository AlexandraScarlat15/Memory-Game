using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Memory_game.Commands;

namespace Memory_game.ViewModels
{
    public class CreateUserViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> AvatarPaths { get; set; }
        private int _selectedIndex;
        private string _username;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        public string SelectedAvatar => AvatarPaths[_selectedIndex];

        #region Commands

        public ICommand NextCommand { get; }
        public ICommand PreviousCommand { get; }
        public ICommand CreateUserCommand { get; }

        #endregion

        public CreateUserViewModel()
        {
            AvatarPaths = new ObservableCollection<string>
            {
                "Images/Viking.png",
                "Images/VikingGirl.png",
                "Images/YoungWizard.png",
                "Images/Witch.png",
                "Images/AngryViking.png",
                "Images/FarmGirl.png",
                "Images/Wizard.png"
            };

            _selectedIndex = 0;

            NextCommand = new RelayCommand(() =>
            {
                _selectedIndex = (_selectedIndex + 1) % AvatarPaths.Count;
                OnPropertyChanged(nameof(SelectedAvatar));
            });

            PreviousCommand = new RelayCommand(() =>
            {
                _selectedIndex = (_selectedIndex - 1 + AvatarPaths.Count) % AvatarPaths.Count;
                OnPropertyChanged(nameof(SelectedAvatar));
            });

            CreateUserCommand = new RelayCommand(() =>
            {
                
            });
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
