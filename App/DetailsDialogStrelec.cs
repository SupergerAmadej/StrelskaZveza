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
    public partial class DetailsDialogStrelec : Form
    {
        public string Item { get; set; }

        private ServiceReferenceSZ.Strelec Strelec { get; set; }
        private static ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();

        public DetailsDialogStrelec()
        {
            InitializeComponent();
        }

        private void DetailsDialog_Load(object sender, EventArgs e)
        {
            Strelec = client.GetStrelec(Item);

            button_shrani_podatke.DialogResult = DialogResult.OK;

            textBoxIme.Text = Strelec.Ime;
            textBoxPriimek.Text = Strelec.Priimek;
            textBoxLetoRojstva.Text = Strelec.LetoRojstva.ToString();

            var klubi = client.ReturnStrelecVKlubus();
            var strelecKlubi = klubi.Where(a => a.Strelec.StrelecID == Strelec.StrelecID).ToList();
            strelecKlubi.Where(a => a.Do == null).ToList().ForEach(a => a.Klub.Naziv = a.Klub.Naziv + " **");

            var cStrelecKlubi = (from a in strelecKlubi
                                 select new
                                 {
                                     Naziv = a.Klub.Naziv,
                                     StrelecKlubID = a.StrelecKlubID
                                 }).ToList();

            listBox1.DataSource = null;
            listBox1.DisplayMember = "Naziv";
            listBox1.ValueMember = "StrelecKlubID";
            listBox1.DataSource = cStrelecKlubi;


            List<ServiceReferenceSZ.Klub> vsiKlubi = new List<ServiceReferenceSZ.Klub>();
            vsiKlubi = client.ReturnKlubi().ToList();
            listBox2.DataSource = null;
            listBox2.DisplayMember = "Naziv";
            listBox2.ValueMember = "KlubID";
            listBox2.DataSource = vsiKlubi;
        }

        private void button_shrani_podatke_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLetoRojstva.Text, out int letoRojstva))
            {
                ServiceReferenceSZ.Strelec newStrelec = new ServiceReferenceSZ.Strelec
                {
                    StrelecID = Strelec.StrelecID,
                    Ime = textBoxIme.Text,
                    Priimek = textBoxPriimek.Text,
                    LetoRojstva = letoRojstva
                };
                if (client.UpdateStrelec(newStrelec))
                    Strelec = newStrelec;
                else
                    MessageBox.Show("napaka pri posodabljanju podatkovne baze");
            }
            else
                MessageBox.Show("leto rojstva mora biti stevilo!");
            
        }

        private void button_dodaj_klub_Click(object sender, EventArgs e)
        {
            client.DodajStrelcaVklub(Strelec, listBox2.SelectedValue.ToString());
            DetailsDialog_Load(this, new EventArgs());
        }

        private void button_brisi_klub_Click(object sender, EventArgs e)
        {
            client.DeleteSVK(listBox1.SelectedValue.ToString());
            DetailsDialog_Load(this, new EventArgs());

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DetailsDialogBridge ddb = new DetailsDialogBridge();
            ddb.IdSVK = int.Parse(listBox1.SelectedValue.ToString());
            ddb.ShowDialog();
            if (ddb.DialogResult == DialogResult.OK)
                DetailsDialog_Load(this, new EventArgs());
        }
    }
}
