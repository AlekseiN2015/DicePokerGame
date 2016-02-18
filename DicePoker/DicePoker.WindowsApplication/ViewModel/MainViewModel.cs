using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DicePoker.Library.Implementations;

namespace DicePoker.WindowsApplication.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private void StartGame()
        {
            var game = new SinglePlayerGame();
            game.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
