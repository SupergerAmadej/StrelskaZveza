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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for prijava.xaml
    /// </summary>
    public partial class prijava : Window
    {
        public prijava()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();
            ServiceReferenceSZ.User u = new ServiceReferenceSZ.User
            {
                Ime = textBoxi.Text,
                Geslo = passwordBox.Password.ToString()
            };
            if (client.CheckUser(u, out bool admin))
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
            else
                MessageBox.Show("napacno geslo");
        }
    }
}
