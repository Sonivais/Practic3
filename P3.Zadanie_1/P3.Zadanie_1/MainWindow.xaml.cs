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

namespace P3.Zadanie_1
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
            if (!Double.TryParse(TextBox.Text, out double num))
            { MessageBox.Show("Поле только для чисел"); }
            if (num > 9 && num < 100)
            {
                double sum;
                sum = num % 10 + Math.Truncate(num / 10 % 10);

                MessageBox.Show(sum.ToString());
                if (sum % 2 == 0)
                {
                    Answer.Text += "Да!";
                }
                else
                {
                    Answer.Text += "Нет!";
                }
            }
        }
    }
}
