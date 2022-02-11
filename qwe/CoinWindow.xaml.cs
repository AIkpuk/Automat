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
using System.IO;
using System.Reflection;

namespace qwe
{
    /// <summary>
    /// Логика взаимодействия для CoinWindow.xaml
    /// </summary>
    public partial class CoinWindow : Window
    {
        public CoinWindow(int x1, int x2, int x5, int x10)
        {
            InitializeComponent();

            string path = Directory.GetCurrentDirectory();
            path = path.Replace("\\qwe\\bin\\Debug", "\\BD\\");
            FileStream file1 = new FileStream(path + "1.txt", FileMode.Open);
            StreamReader reader1 = new StreamReader(file1);
            string ax1 = reader1.ReadToEnd();
            reader1.Close();

            FileStream file2 = new FileStream(path + "2.txt", FileMode.Open);
            StreamReader reader2 = new StreamReader(file2);
            string ax2 = reader2.ReadToEnd();
            reader2.Close();

            FileStream file5 = new FileStream(path + "5.txt", FileMode.Open);
            StreamReader reader5 = new StreamReader(file5);
            string ax5 = reader5.ReadToEnd();
            reader5.Close();

            FileStream file10 = new FileStream(path + "10.txt", FileMode.Open);
            StreamReader reader10 = new StreamReader(file10);
            string ax10 = reader10.ReadToEnd();
            reader10.Close();

            MessageBox.Show("1 руб: " + ax1 + " 2 руб: " + ax2 + " 5 руб: " + ax5 + " 10 руб: " + ax10);
            TB1.Text = Convert.ToString(ax1);
            TB2.Text = Convert.ToString(ax2);
            TB5.Text = Convert.ToString(ax5);
            TB10.Text = Convert.ToString(ax10);
        }

        private void BTBack_Click(object sender, RoutedEventArgs e)
        {

            

        }
    }
}
