using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommandsPr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private int _currentButton;
        public MainWindow()
        {
            InitializeComponent();
            _currentButton = random.Next(3); 
        }

        private void Sit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Сижу");
            _currentButton = random.Next(3);
        }
        private void Lay_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Лежу");
            _currentButton = random.Next(3);
        }
        private void Voice_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Гав-гав");
            _currentButton = random.Next(3);
        }
        
        private void Sit_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _currentButton == 0;
        }
        private void Lay_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _currentButton == 1;
        }
        private void Voice_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _currentButton == 2;
        }
    }
}