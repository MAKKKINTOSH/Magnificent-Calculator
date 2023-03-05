using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Magnificent_Calculator
{
    class Display
    {
        public static void AddNumberToTextBox(TextBox textBox, string value)
        {
            textBox.Text += value;
        }
        public static void AddDotToTextBox(TextBox textBox)
        {
            if (!textBox.Text.Contains('.'))
            {
                textBox.Text += ".";
            }
        }
    }
}
