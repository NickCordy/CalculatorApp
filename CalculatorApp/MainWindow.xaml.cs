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
using static CalculatorApp.Calculator;

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calculator;

        public MainWindow()
        {
            InitializeComponent();
            calculator = new();
        }

        private void UpdateDisplay()
        {
            string op = string.Empty;

            switch (calculator.operation)
            {
                case Operation.NONE:
                    op = string.Empty;
                    break;
                case Operation.DIVIDE:
                    op = " / ";
                    break;
                case Operation.MULTIPLY:
                    op = " x ";
                    break;
                case Operation.SUBTRACT:
                    op = " - ";
                    break;
                case Operation.ADD:
                    op = " + ";
                    break;
            }

            txtDisplay.Text = calculator.firstNumber + op + calculator.secondNumber;
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            calculator.Percent();
            UpdateDisplay();
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            calculator.ClearEntry();
            UpdateDisplay();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            calculator.Clear();
            UpdateDisplay();
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            calculator.Backspace();
            UpdateDisplay();
        }

        private void btnReciprocal_Click(object sender, RoutedEventArgs e)
        {
            calculator.Reciprocal();
            UpdateDisplay();
        }

        private void btnSquare_Click(object sender, RoutedEventArgs e)
        {
            calculator.Square();
            UpdateDisplay();
        }

        private void btnSquareRoot_Click(object sender, RoutedEventArgs e)
        {
            calculator.SquareRoot();
            UpdateDisplay();
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            calculator.operation = Operation.DIVIDE;
            UpdateDisplay();
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            calculator.operation = Operation.MULTIPLY;
            UpdateDisplay();
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            calculator.operation = Operation.SUBTRACT;
            UpdateDisplay();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            calculator.operation = Operation.ADD;
            UpdateDisplay();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            calculator.AppendToNumber("0");
            UpdateDisplay();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            calculator.AppendToNumber("1");
            UpdateDisplay();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            calculator.AppendToNumber("2");
            UpdateDisplay();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            calculator.AppendToNumber("3");
            UpdateDisplay();
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            calculator.AppendToNumber("4");
            UpdateDisplay();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            calculator.AppendToNumber("5");
            UpdateDisplay();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            calculator.AppendToNumber("6");
            UpdateDisplay();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            calculator.AppendToNumber("7");
            UpdateDisplay();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            calculator.AppendToNumber("8");
            UpdateDisplay();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            calculator.AppendToNumber("9");
            UpdateDisplay();
        }

        private void btnNegate_Click(object sender, RoutedEventArgs e)
        {
            calculator.Negate();
            UpdateDisplay();
        }

        private void btnDecimalPoint_Click(object sender, RoutedEventArgs e)
        {
            calculator.AppendToNumber(".");
            UpdateDisplay();
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            calculator.Calculate();
            UpdateDisplay();
        }
    }
}