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

namespace _06_WPF_08_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum Operation { Add, Subtract, Multiply, Divide }

        private double _lastNumber;
        private string _currentInput;
        private Operation _lastOperation;

        public MainWindow()
        {
            InitializeComponent();
            _currentInput = "0";
        }

        private void RenderDisplay()
        {
            DisplayTB.Text = _currentInput;
        }

        private void NumberBtn_Click(object sender, RoutedEventArgs e)
        {
            Button pressedBtn = (Button)sender;
            string digit = pressedBtn.Content.ToString();

            if (_currentInput == "0")
                _currentInput = "";

            _currentInput += digit;
            RenderDisplay();
        }

        private void ACButton_Click(object sender, RoutedEventArgs e)
        {
            _currentInput = "0";
            RenderDisplay();
        }
    }
}