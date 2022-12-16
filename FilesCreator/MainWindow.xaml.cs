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

namespace FilesCreator
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
            string s ="";
             double a = 1000;
             for (int i = 0; i < a; i++)
             {
                 double x = -5 + 10 / a * i;
                 s += (x).ToString() +'\t';
                 s += (Math.Sin(x)).ToString()  +"\t1\n";
             } 

          /*  for (int i = -5; i < 5; i++)
            {
                s += (i).ToString() + '\t'+(Math.Pow(i,3)).ToString()+'\n';
            }*/

                System.IO.File.WriteAllText("..\\...\\...\\file.txt", s);
        }
    }
}
