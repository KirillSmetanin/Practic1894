using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace Задание_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public string Div(double x, double y)
        {
            if (y != 0)
                return $"{x / y}";
            else
                return "На ноль не делится";
        }

        private void count_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(numberOne.Text);
                double y = Convert.ToDouble(numberTwo.Text);
                string Method = Convert.ToString(method.Text);
                switch (Method)
                {
                    case "+":
                        answer1.Content = Add(x, y);
                        break;
                    case "-":
                        answer1.Content = Sub(x, y);
                        break;
                    case "*":
                        answer1.Content = Mul(x, y);
                        break;
                    case "/":
                        answer1.Content = Div(x, y);
                        break;
                }
            }
            catch
            {
                answer1.Content = "Error";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double Conv(double Money, double Conversion)
        {
            return Money * Conversion;
        }

        private void countMoney_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double Money = Convert.ToDouble(money.Text);
                double Conversion = Convert.ToDouble(conversion.Text);
                answer2.Content = "" + Conv(Money, Conversion);
            }
            catch
            {

            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Pol(double x)
        {
            string g;
            if (x < 0)
                g = "Число отрицательное,";
            else if (x > 0)
                g = "Число положительное,";
            else
            {
                g = "Число = 0,";
            }
            return g;
        }

        public string Prost (double x)
        {
            string F;
            if (x / 1 == x && x / x == 1 && x == Math.Truncate(x))
                F = " число простое, ";
            else
                F = " число не простое, ";
            return F;
        }

        public string Delux(double x)
        {
            string H;
            if (x % 2 == 0 && x % 3 == 0 && x % 5 == 0 && x % 6 == 0 && x % 9 == 0)
            {
                H = " число делиться без остатка.";
            }
            else
            {
                H = " число делиться с остатком.";
            }
            return H;
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(number1.Text);
                answer3.Content = "" + Pol(x) + Prost(x) + Delux(x);
        }

        /// <summary>
        /// 
        /// </summary>
       
        double x = 0;
        int i = 0;
        public string Vr()
        {
            string c = "";
            double y = Convert.ToDouble(payment.Text);
            x += y;
            if (i < 7)
            {
                if (x < 5000)
                {
                    c = $"Сумма задолженности {5000 - x}";
                    i++;
                }
                else if (x == 5000)
                {
                    i++;
                    c = "Долг погашен";
                }
                else if (x > 5000)
                {
                    i++;
                    c = $"Долг погашен, переплата {x - 5000}";
                }
            }
            else
                c = "Вы не успели погасить долг";
            return c;
        }


        

        private void pay_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(payment.Text);
            Info.Content = "" + Vr();
        }

        /// <summary>
        /// 
        /// </summary>

        public string Chisl(int n)
        {
            int i = 1;
            int sum = 1;
        LB1: if (i <= n)
            {
                sum *= i;
                i++;
                goto LB1;
            }
            else
                return "" + sum;
        }

            private void customersCount_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(customers.Text);

            answer4.Content = Chisl(n);
        }
    }
}
