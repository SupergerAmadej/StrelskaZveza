using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();
            ServiceReferenceSZ.User u = new ServiceReferenceSZ.User
            {
                Ime = textBox1.Text,
                Geslo = textBox2.Text
            };
            if (client.CheckUser(u, out bool admin))
            {
                MainWindow mw = new MainWindow();
                this.Hide();
                mw.Show();
            }
            else
                MessageBox.Show("napacno geslo");

        }
    }
}
