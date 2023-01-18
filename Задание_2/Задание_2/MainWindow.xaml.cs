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

namespace Задание_2
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
            double ПеременныяСЗапятой;
            int ПростоеЧисло;
            string ИмяМага;
            int ПерваяПеременная;
            double Жизни;
            string НазваниеКоробля;
            int ЧислоЧекпоинтов;
            double Манна;
            string КнигаАвтор;
            int КаличествоВыпушенныхКниг;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int СколькоКартинок = Convert.ToInt32(КаличествоЧиселВРяду.Text);
                int ВсегоКартинок = Convert.ToInt32(КалКартинок.Text);
                Ответ.Content = ВсегоКартинок / СколькоКартинок;
            }
            catch
            {
                MessageBox.Show("Введите данные коректней", "Ошибка");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                int СколькоДенег = Convert.ToInt32(Деньги.Text);
                int СколькоКристалов = Convert.ToInt32(Кристалы.Text);
                int Стоимость = (СколькоКристалов * 100);
                int Ответ = СколькоДенег - Стоимость;
                if (Ответ < 0)
                {
                    MessageBox.Show("Не хватает денег", "Ошибка");
                }
                else
                Ответ_2.Content = Ответ;
            }
            catch
            {
                MessageBox.Show("Введите данные коректней", "Ошибка");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                int КаличествоЛюдей = Convert.ToInt32(КалЛюд.Text);
                int Часы = (КаличествоЛюдей * 10) / 60;
                int Минуты = (КаличествоЛюдей * 10) - (Часы * 60);
                Ответ_3.Content = "Время:" + Часы + "Часа" + Минуты + "минут";
            }
            catch
            {
                MessageBox.Show("Вводиться каличество бабушек","Ошибка");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                string Имя = Convert.ToString(ФИО.Text);
                int возрост = Convert.ToInt32(Лет.Text);
                string Задиак = Convert.ToString(Зад.Text);
                if (возрост < 0)
                {
                    MessageBox.Show("Возраст не может быть отрицательный", "Ошибка");
                }
                else
                    Вывод.Content = "Вас зовут " + Имя + " вам " + возрост + " знак задиака - " + Задиак;
            }
            catch
            {
                MessageBox.Show("Введите данные корректней", "Ошибка");
            }
        }
    }
}
