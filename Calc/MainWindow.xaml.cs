using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Calc
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

        public double a;
        public double b;
        public char c;


        #region "Инициализация клавиатуры калькулятора"
        private void ButtonPowerOff_Click(object sender, RoutedEventArgs e)
        {
            
            
        }
       
        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "0";
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "9";
        }
        #endregion 

        //При нажатии на кнопку + переменная стоящая в текст боксе записывается в переменную а textbox очищается 
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                c = '+';
            }
            catch(Exception)
            {

            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                c = '-';
            }
            catch(Exception)
            {

            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                c = '*';
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                c = '/';
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Когда мы нажимаем равно
            b = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

            switch (c) 
            {
                case '+':
                    {
                        textBox1.Text = Convert.ToString(a + b);
                        string t = Convert.ToString(a);
                        string y = Convert.ToString(b);
                        textBox2.Text = t + " + " + y;
                        break;
                    }
                case '-':
                    {
                        textBox1.Text = Convert.ToString(a - b);
                        string t = Convert.ToString(a);
                        string y = Convert.ToString(b);
                        textBox2.Text = t + " - " + y;
                        break;
                    }
                case '*':
                    {
                        textBox1.Text = Convert.ToString(a * b);
                        string t = Convert.ToString(a);
                        string y = Convert.ToString(b);
                        textBox2.Text = t + " * " + y;
                        break;
                    }
                case '/':
                    {
                        textBox1.Text = Convert.ToString(a / b);
                        string t = Convert.ToString(a);
                        string y = Convert.ToString(b);
                        textBox2.Text = t + " / " + y;
                        break;
                    }
            }

            

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            textBox1.Text += ",";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";

            a = 0;
            b = 0;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = textBox1.Text;
                s = s.Substring(0, s.Length - 1);
                textBox1.Text = s;
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                a = Math.Sqrt(a);
                textBox1.Text = Convert.ToString(a);
            }
            catch (Exception)
            {

            }
        }

        private void ButtonPowerOff_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
