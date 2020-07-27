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
    public partial class DialogNewEntity : Form
    {
        public int Tip { get; set; }
        private static ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();
        public DialogNewEntity()
        {
            InitializeComponent();
        }

        private void DialogNewEntity_Load(object sender, EventArgs e)
        {
            button_dodaj.DialogResult = DialogResult.OK;
            if (Tip == 1)
            {
                label_ime_naziv.Text = "Naziv:";
                label_naslov_priimek.Text = "Naslov:";
                label_lr_lr.Text = "Leto ustanovitve:";
            }
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            if(Tip == 0)
            {
                if (int.TryParse(textBox_lr.Text, out int lr))
                {
                    ServiceReferenceSZ.Strelec s = new ServiceReferenceSZ.Strelec
                    {
                        Ime = textBox_ime.Text,
                        Priimek = textBox_priimek.Text,
                        LetoRojstva = lr
                    };
                    client.AddStrelec(s, out int id);
                }
                else
                    MessageBox.Show("Leto rojstva mora biti stevilo");
            }
            else
            {
                if (int.TryParse(textBox_lr.Text, out int lr))
                {
                    ServiceReferenceSZ.Klub k = new ServiceReferenceSZ.Klub
                    {
                        Naziv = textBox_ime.Text,
                        Naslov = textBox_priimek.Text,
                        LetoUstanovitve = lr
                    };
                    client.AddKlub(k);
                }
                else
                    MessageBox.Show("Leto ustanovitve mora biti stevilo");
            }
        }


    }
}
