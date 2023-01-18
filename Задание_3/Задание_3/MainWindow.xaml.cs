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

namespace Задание_3
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            l.Content = "";
            try
            {
                string a = Convert.ToString(tran.Text);
                if (a == "дождь")
                    res.Text = "rain";
                else if (a == "ветер")
                    res.Text = "wind";
                else if (a == "снег")
                    res.Text = "snow";
                else if (a == "тепло")
                    res.Text = "warm";
                else if (a == "ходод")
                    res.Text = "cold";
                else if (a == "радуга")
                    res.Text = "rainbow";
                else if (a == "ураган")
                    res.Text = "hurricane";
                else if (a == "солнечно")
                    res.Text = "sunny";
                else if (a == "пасмурно")
                    res.Text = "cloudy";
                else if (a == "прогноз")
                    res.Text = "forecast";
                else
                {
                    l.Content = "Невозможно перевести слово";
                    l.Foreground = Brushes.Red;
                    res.Text = "";
                }

            }
            catch
            { 
            
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double operand1 = Convert.ToDouble(A.Text);
            double operand2 = Convert.ToDouble(A_Copy.Text);
            string sign = Convert.ToString(C.Text);
            switch (sign)
            {
                case "+":
                    l1.Content = (operand1 + operand2);
                    break;
                case "-":
                    l1.Content = (operand1 - operand2);
                    break;
                case "*":
                    l1.Content = (operand1 * operand2);
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя.");
                    }
                    else
                    l1.Content = Math.Round(operand1 / operand2, 4);
                    break;
                case "^":
                    l1.Content = Math.Pow(operand1, operand2);
                    break;
                default:
                    MessageBox.Show("Неверный формат данных.");
                    break;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(ПромЧисл.Text);
                if (a >= 0 & a <= 14)
                    MessageBox.Show("Вы попали в промежуток: [0 - 14]");
                else if (a >= 15 & a <= 35)
                    MessageBox.Show("Вы попали в промежуток: [15 - 35]");
                else if (a >= 36 & a <= 50)
                    MessageBox.Show("Вы попали в промежуток: [36 - 55]");
                else if (a >= 51 & a <= 100)
                    MessageBox.Show("Вы попали в промежуток: [51 - 100]");
                else
                    MessageBox.Show("Вы не попали в промежутки");
            }
            catch
            {
                MessageBox.Show("Неверный формат данных");
            }
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string password = "password";
            string a = Convert.ToString(p.Text);
            if (a == password)
            {
                Ol2.Content = "Секретное сообщение: Ты отгадал пароль!";
            }
            else
                Ol2.Content = "Неправильный пароль!";
        }
    }
}
