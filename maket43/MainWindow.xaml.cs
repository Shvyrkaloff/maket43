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

namespace maket43
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
            MessageBox.Show("От нас не уезжают, а улетают");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Услуга 1\nУслуга 2\nУслуга 3\nУслуга 4\nУслуга 5\nУслуга 6\nУслуга 7\n");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Б красная 18/7 к 306");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            border1.Background = new SolidColorBrush(Colors.Silver);
            border2.Background = new SolidColorBrush(Colors.Silver);
            border3.Background = new SolidColorBrush(Colors.Silver);
            border4.Background = new SolidColorBrush(Colors.Silver);
            border5.Background = new SolidColorBrush(Colors.Silver);
            tool.Background = new SolidColorBrush(Colors.Silver);
            b1.Background = new SolidColorBrush(Colors.Silver);
            b2.Background = new SolidColorBrush(Colors.Silver);
            b3.Background = new SolidColorBrush(Colors.Silver);
            b4.Background = new SolidColorBrush(Colors.Silver);
            text1.Background = new SolidColorBrush(Colors.Silver);
            status.Background = new SolidColorBrush(Colors.Silver);
            gridcar.Background = new SolidColorBrush(Colors.Silver);
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            border1.Background = new SolidColorBrush(Colors.White);
            border2.Background = new SolidColorBrush(Colors.White);
            border3.Background = new SolidColorBrush(Colors.White);
            border4.Background = new SolidColorBrush(Colors.White);
            border5.Background = new SolidColorBrush(Colors.White);
            tool.Background = new SolidColorBrush(Colors.White);
            b1.Background = new SolidColorBrush(Colors.White);
            b2.Background = new SolidColorBrush(Colors.White);
            b3.Background = new SolidColorBrush(Colors.White);
            b4.Background = new SolidColorBrush(Colors.White);
            status.Background = new SolidColorBrush(Colors.White);
            gridcar.Background = new SolidColorBrush(Colors.White);
            text1.Background = new SolidColorBrush(Colors.White);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товар 1\nТовар 2\nТовар 3\nТовар 4\nТовар 5\nТовар 6\nТовар 7\n");
        }
        private void hover1(object sender, MouseEventArgs e)
        {
            Change.Text = "Каталог товаров";
        }

        private void hover2(object sender, MouseEventArgs e)
        {
            Change.Text = "О нас";
        }

        private void hover3(object sender, MouseEventArgs e)
        {
            Change.Text = "Каталог услуг";
        }

        private void hover4(object sender, MouseEventArgs e)
        {
            Change.Text = "Как нас найти";
        }

        private void hover6(object sender, MouseEventArgs e)
        {
            Change.Text = "Светлая тема";
        }

        private void hover5(object sender, MouseEventArgs e)
        {
            Change.Text = "Темная тема";
        }
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                var slider = sender as Slider;
                double value = slider.Value;
                text1.FontSize = value * 3;
            }
            catch
            {
            }
        }
    }
}
