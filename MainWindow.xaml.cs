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
using MahApps.Metro.Controls;

namespace calculator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        double first;
        double second;
        string op;
        double result = 0;
        double Sqrt(double number, double n)
        {
            double r = 0.00000001;
            int max_n = 10;
            double x = number, xp;
            do
            {
                xp = x;
                x = (1 / (double)n) * ((n - 1) * xp + number / Math.Pow(xp, n - 1));
            } while (--max_n > 0 && xp - x > r);
            return x;

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn=(Button)sender;
            Result.Text += btn.Content.ToString();
            second = Double.Parse(Result.Text);
        }
        private void ButtonSqrt_Click(object sender, RoutedEventArgs e)
        {
            first= Double.Parse(Result.Text);
            op = "sqrt";
            Result.Clear();
        }


        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            first = Double.Parse(Result.Text); ;
            op = "/";
            Result.Clear();
        }


        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            first = Double.Parse(Result.Text);
            op = "^";
            Result.Clear();
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            first = Double.Parse(Result.Text);
            op ="*";
            Result.Clear();
        }

        private void ButtonClean_Click(object sender, RoutedEventArgs e)
        {
            first = 0;
            second = 0;
            op = "";
            result = 0;
            Result.Clear();
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            first = Double.Parse(Result.Text);
            op = "-";
            Result.Clear();
        }

        private void ButtonOff_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            first = Double.Parse(Result.Text);
            op = "+";
            Result.Clear();
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            second = Double.Parse(Result.Text);
            if (op == "+") result = first + second;
            else if (op == "-") result = first - second;
            else if (op == "*") result = first * second;
            else if (op == "/") result = first/ second;
            else if (op == "sqrt") result = Sqrt(first, second);
            else if (op == "^") result = Math.Pow(first, second);

            if( Result.Text == "0") Result.Clear();
            Result.Text = result.ToString();
        }

       
    }
}
