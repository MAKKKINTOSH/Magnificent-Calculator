using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Magnificent_Calculator;

namespace Magnificent_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator calculator = new Calculator();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = calculator.Operator;
        }

        private void NumberButtonClick(object sender, RoutedEventArgs e)
        {
            if (calculator.Operator == null)
            {
                if (secondNumber.Text!="")
                {
                    ClearDisplay();
                }
                Display.AddNumberToTextBox(firstNumber, sender.ToString().Substring(32));
                return;
            }
            Display.AddNumberToTextBox(secondNumber, sender.ToString().Substring(32));
        }

        private void DotButtonClick(object sender, RoutedEventArgs e)
        {
            if(calculator.Operator == null)
            {
                Display.AddDotToTextBox(firstNumber);
                return;
            }
            Display.AddDotToTextBox(secondNumber);
        }

        private void OperatorButtonClick(object sender, RoutedEventArgs e)
        {
            if(calculator.Operator == null)
            {
                calculator.Operator = sender.ToString().Substring(32);
                operationSymbol.Text = sender.ToString().Substring(32);
            }
        }

        private void EqualButtonClick(object sender, RoutedEventArgs e)
        {
            if (secondNumber.Text!="" && answer.Text == "")
            {
                calculator.Number_1 = int.Parse(firstNumber.Text);
                calculator.Number_2 = int.Parse(secondNumber.Text);
                answer.Text = calculator.Calculate().ToString();
                calculator.Operator = null;
            }
        }

        private void BackspaceButtonClick(object sender, RoutedEventArgs e)
        {
            if (secondNumber.Text=="")
            {
                firstNumber.Text = firstNumber.Text.Remove(firstNumber.Text.Length - 1);
                return;
            }
            secondNumber.Text = secondNumber.Text.Remove(secondNumber.Text.Length - 1);
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            ClearDisplay();
        }
        private void ClearDisplay()
        {
            firstNumber.Text  = "";
            secondNumber.Text = "";
            answer.Text = "";
            calculator.Operator = null;
            operationSymbol.Text = null;
        }
    }
}
