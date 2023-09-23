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
using System.Windows.Shapes;

namespace prt2
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            {
                int[] array = { 1, 1, 2, 2, 2, 3, 4, 4, 5, 6, 6, 6, 6, 7 };
                string result = GetSeriesLengths(array);
                MessageBox.Show(result);
            }
        }

        private static string GetSeriesLengths(int[] array)
        {
            StringBuilder sb = new StringBuilder();
            int currentNumber = array[0];
            int count = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == currentNumber) // продолжение серии
                {
                    count++;
                }
                else // новая серия
                {
                    sb.Append(count);
                    sb.Append(" ");
                    currentNumber = array[i];
                    count = 1;
                }
            }

            // Добавляем длину последней серии
            sb.Append(count);

            return sb.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.ShowDialog();
        }
    }
}
    

