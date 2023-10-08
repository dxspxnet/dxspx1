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
using Libx;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил: Шабакаев Руслан Рушанович\nГруппа:ИСП-34\nВариант: 10\nВвести n целых чисел. Вычислить для чисел > 0 функцию корень из x. Результат обработки каждого числа вывести на экран");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(zn1.Text);                                //Переменная n получает значение, преобразованное из текста, введенного в элемент управления с именем zn1. 
            for (int i = 0; i < n; i++)                                 //Выполняется от 0 до значения переменной n, с шагом 1. 
            {
                Random rnd = new Random();
                int number = rnd.Next(n);                               //Внутри цикла переменная number получает значение, преобразованное из текста, введенного в элемент управления с именем zn2. 
                try                                                     //Блок try-catch используется для обработки возможного исключения типа ArgumentException. 
                {                                                       //Внутри блока try выполняется вычисление квадратного корня числа, которое хранится в переменной number, используя статический метод SquareRoot класса MathFunctions. Результат присваивается переменной result. 
                    double result = MathFunctions.SquareRoot(number);
                    res2.Text = Convert.ToString(result);               //Значение переменной result конвертируется в строковый формат и присваивается элементу управления с именем res2. 
                    res.Text = Convert.ToString(number);                //Значение переменной number конвертируется в строковый формат и присваивается элементу управления с именем res. 
                }
                catch (ArgumentException ex)                            //Если в блоке try возникает исключение типа ArgumentException, то выведется сообщение об ошибке, содержащее текст сообщения об исключении. Программа завершит свою работу.
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            res.Clear();                                                //Очистка TextBox res
            res2.Clear();                                               //Очистка TextBox res2
            zn1.Clear();                                                //Очистка TextBox zn1
            zn2.Clear();                                                //Очистка TextBox zn2
        }
    }
}
