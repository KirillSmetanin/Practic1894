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

namespace Задание_4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(A.Text);
                int b = Convert.ToInt32(B.Text);
                for (int i = a+1; i < b; i++)
                {
                    I1.Content += "" + i;
                    if(i % 2 == 1)
                    {
                        I2.Content += "" + i;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(N.Text);
                int i = 0;
                int j = 1;
                do
                {
                    i++;
                    j *= i;
                }

                while (i < n);
                L1.Content = "" + j;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 10; i <= 20; i++)
                {
                    L2.Content += " " + Math.Pow(i, 2);
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(U.Text);
                int i = -1;
                int j = 0;
                do
                {
                    i++;
                    j += i;
                }

                while (i < n);
                E.Content = "" + j;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }
        double resZarplata;
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                double zarplata = Convert.ToDouble(Zarplata.Text);
                int year = Convert.ToInt32(Year.Text);
                if (year > 0)
                {
                    if (year < 5)
                    {
                        resZarplata = zarplata + (zarplata * 0.1d);
                    }
                    else if (year >= 5 && year < 10)
                    {
                        resZarplata = zarplata + (zarplata * 0.15d);
                    }
                    else if (year >= 10 && year < 15)
                    {
                        resZarplata = zarplata + (zarplata * 0.25d);
                    }
                    else if (year >= 15 && year < 20)
                    {
                        resZarplata = zarplata + (zarplata * 0.35d);
                    }
                    else if (year >= 20 && year < 25)
                    {
                        resZarplata = zarplata + (zarplata * 0.45d);
                    }
                    else if (year >= 25)
                    {
                        resZarplata = zarplata + (zarplata * 0.50d);
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
                U1.Content = "" + resZarplata;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(N.Text);
                int i = 0;
                int j = 1;
                lab3:
                if(i<n)
                {
                    goto lab1;
                }
                else
                {
                    goto lab2;
                }
                lab1:
                    i++;
                    j *= i;
                    goto lab3;
                lab2:
                    R.Content = "" + j;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
