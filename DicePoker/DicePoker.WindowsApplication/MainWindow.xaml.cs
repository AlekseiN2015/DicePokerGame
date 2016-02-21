using System.Windows;
using DicePoker.WindowsApplication.ViewModel;

namespace DicePoker.WindowsApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void ButtonCloseClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
