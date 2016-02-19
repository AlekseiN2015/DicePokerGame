using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DicePoker.Library.Implementations;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace DicePoker.WindowsApplication.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private void StartSingleGame()
        {
            var game = new SinglePlayerGame();
            game.Start();

        }

        private void StartMultiGame()
        {
            var game = new MultiPlayerGame();
            game.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand StartSingleGameCommand { get; }
        public ICommand StartMultiGameCommand { get; }

        public MainViewModel()
        {
            StartSingleGameCommand = new RelayCommand(StartSingleGame);
            StartMultiGameCommand = new RelayCommand(StartMultiGame);

        }

       
    }

}
