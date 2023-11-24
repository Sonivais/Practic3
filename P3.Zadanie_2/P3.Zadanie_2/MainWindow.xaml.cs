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

namespace P3.Zadanie_2
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

            if (!Double.TryParse(TextBox1.Text, out double R1))
            { MessageBox.Show("Поле только для чисел"); }
            if (!Double.TryParse(TextBox2.Text, out double R2))
            { MessageBox.Show("Поле только для чисел"); }
            if (R1 > R2)
            {
                Answer.Text += "Первое больше";
            }
            else
            {
                Answer.Text += "Второе больше";
            }
        }
    }
}
