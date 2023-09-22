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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                int[] array = { 4, 5, 6, 7, -12, -3, 4, -5, -7, 2 };

                int maxNegativeIndex = -1;
                int minPositiveIndex = -1;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        if (maxNegativeIndex == -1 || array[i] > array[maxNegativeIndex])
                        {
                            maxNegativeIndex = i;
                        }
                    }
                    else if (array[i] > 0)
                    {
                        if (minPositiveIndex == -1 || array[i] < array[minPositiveIndex])
                        {
                            minPositiveIndex = i;
                        }
                    }
                }

                if (maxNegativeIndex != -1 && minPositiveIndex != -1)
                {
                    int temp = array[maxNegativeIndex];
                    array[maxNegativeIndex] = array[minPositiveIndex];
                    array[minPositiveIndex] = temp;

                    MessageBox.Show($"Первый элемент равен {array[0]}, на позиции 4, второй элемент равен {array[9]}, на позиции 9. Результат перестановки: {string.Join(" ", array)}");
                }
                else
                {
                    MessageBox.Show("В массиве отсутствуют необходимые элементы для перестановки.");
                }
            }
        }
    }
}
    

