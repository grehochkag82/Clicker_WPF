
using System.Windows;

namespace Clicker_WPF_
{
    public partial class MainWindow : Window
    {
        private int _counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            UpdateCounterText();
        }
        
        private void Bytton_Click(object sender, RoutedEventArgs e)
        {
            _counter++;
            UpdateCounterText();
        }
        private void Bytton_Reset(object sender, RoutedEventArgs e)
        {
            _counter = 0;
            UpdateCounterText();
        }
        private void UpdateCounterText()
        {
            CounterText.Text = $"Счетчик:{_counter}";
        }
    }

}