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

namespace BasicCalaulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                BtnTxt.Text = number2.ToString();
            }
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                BtnTxt.Text = number2.ToString();
            }

        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                BtnTxt.Text = number2.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                BtnTxt.Text = number2.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                BtnTxt.Text = number2.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                BtnTxt.Text = number2.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                BtnTxt.Text = number2.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                BtnTxt.Text = number2.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                BtnTxt.Text = number2.ToString();
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                BtnTxt.Text = number2.ToString();
            }
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            BtnTxt.Text = "0";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            BtnTxt.Text = "0";
        }

        private void BtnMultiplay_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            BtnTxt.Text = "0";
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            BtnTxt.Text = "0";
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    BtnTxt.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    BtnTxt.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    BtnTxt.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    BtnTxt.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            BtnTxt.Text = "0";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            BtnTxt.Text = "0";
        }


        private void BtnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * -1);
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * -1);
                BtnTxt.Text = number2.ToString();
            }
        }

        private void Btndel_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                BtnTxt.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                BtnTxt.Text = number2.ToString();
            }
        }
    }
}
