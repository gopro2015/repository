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
using System.Windows.Threading; //подключение библиотеки счётчика

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
                InitializeComponent();
                DispatcherTimer vladick = new DispatcherTimer(); //переменной vladick присваиваем диспетчер таймера
                vladick.Interval = TimeSpan.FromSeconds(1); //задаём интервал в одну секунду 
                vladick.Tick += timer_Tick; //приравнение имён
                vladick.Start(); //старт таймера
        }

        static int count = 30; //задаём 30 секунд

        public void timer_Tick(object sender, EventArgs e)
        {
            count--; //обратный отсчёт, минус по секунде
            schet.Content = VisualChildrenCount; //вывод таймера
            if (count < 30) 
            {
                lamp1.Fill = Brushes.Red;
                lamp2.Fill = Brushes.Gray;
                lamp3.Fill = Brushes.Gray;
            }
            if (count < 26)
            {
                lamp1.Fill = Brushes.Red;
                lamp2.Fill = Brushes.Yellow;
                lamp3.Fill = Brushes.Gray;
            }
            if (count < 20)
            {
                lamp1.Fill = Brushes.Gray;
                lamp2.Fill = Brushes.Gray;
                lamp3.Fill = Brushes.Green;
            }
            if (count < 15)
            {
                lamp1.Fill = Brushes.Gray;
                lamp2.Fill = Brushes.Yellow;
                lamp3.Fill = Brushes.Green;
            }
            if (count < 10)
            {
                count = 30; //зацикливаем
            }

        }

    
    }
}
