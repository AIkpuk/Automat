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

namespace qwe
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        int ax1, ax2, ax5, ax10;
        public Auth(int x1, int x2, int x5, int x10)
        {
            InitializeComponent();
            
            ax1 = x1;
            ax2 = x2;
            ax5 = x5;
            ax10 = x10;
        }

        private void AuthBT_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text == "ADM")
            {
                if (PassPB.Password == "123")
                {
                    admWindow adm = new admWindow(ax1, ax2, ax5, ax10);
                    adm.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
            
            
            

        }
    }
}
