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

namespace Modul2_1302200052
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal bilangan1;
        decimal bilangan2;
        int penjumlahan;
        Boolean penjumlahanakhir = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text == "")
            {
                display.Text = "1";
            }
            else
            {
                display.Text += "1";
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text == "")
            {
                display.Text = "2";
            }
            else
            {
                display.Text += "2";
            }

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text == "")
            {
                display.Text = "3";
            }
            else
            {
                display.Text += "3";
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text == "")
            {
                display.Text = "4";
            }
            else
            {
                display.Text += "4";
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text == "")
            {
                display.Text = "5";
            }
            else
            {
                display.Text += "5";
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text == "")
            {
                display.Text = "6";
            }
            else
            {
                display.Text += "6";
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text == "")
            {
                display.Text = "7";
            }
            else
            {
                display.Text += "7";
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text == "")
            {
                display.Text = "8";
            }
            else
            {
                display.Text += "8";
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text == "")
            {
                display.Text = "9";
            }
            else
            {
                display.Text += "9";
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (display.Text == "")
            {
                display.Text = "0";
            }
            else
            {
                display.Text += "0";
            }
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            bilangan1 = Convert.ToDecimal(display.Text);
            display.Text = " ";
            penjumlahan = 1;
            penjumlahanakhir = true;
        }

        private void buttonSamadengan_Click(object sender, RoutedEventArgs e)
        {
            if (penjumlahanakhir == true)
                bilangan2 = Convert.ToDecimal(display.Text);
            {
                display.Text = Convert.ToString(bilangan1 + bilangan2);
            }
        }
    }
}
