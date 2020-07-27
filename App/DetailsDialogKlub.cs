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
    public partial class DetailsDialogKlub : Form
    {
        public string Item { get; set; }

        private ServiceReferenceSZ.Klub Klub { get; set; }
        private static ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();

        private static int toSort = -1;

        public DetailsDialogKlub()
        {
            InitializeComponent();
        }

        private void DetailsDialogKlub_Load(object sender, EventArgs e)
        {
            Klub = client.GetKlub(Item);

            button_shrani_podatke.DialogResult = DialogResult.OK;

            textBoxIme.Text = Klub.Naziv;
            textBoxPriimek.Text = Klub.Naslov;
            textBoxLetoRojstva.Text = Klub.LetoUstanovitve.ToString();

            var strelci = client.ReturnStrelecVKlubus();
            var klubiStrelec = strelci.Where(a => a.Klub.KlubID == Klub.KlubID).ToList();
            klubiStrelec.Where(a => a.Do != null).ToList().ForEach(a => a.Strelec.Priimek = a.Strelec.Priimek + " **"); //veri ugly lol

            if (toSort == 0) //sort
                klubiStrelec = klubiStrelec.OrderByDescending(a => a.Strelec.LetoRojstva).ToList();
            else if(toSort ==1)
                klubiStrelec = klubiStrelec.OrderBy(a => a.Strelec.Priimek).ToList();
            else if(toSort == 2)
                klubiStrelec = klubiStrelec.OrderBy(a => a.Strelec.Ime).ToList();


            var cStrelecKlubi = (from a in klubiStrelec
                                 select new
                                 {
                                     Naziv = a.Strelec.Ime + " " + a.Strelec.Priimek,
                                     StrelecKlubID = a.StrelecKlubID
                                 }).ToList();

            listBox1.DataSource = null;
            listBox1.DisplayMember = "Naziv";
            listBox1.ValueMember = "StrelecKlubID";
            listBox1.DataSource = cStrelecKlubi;
        }

        private void button_shrani_podatke_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLetoRojstva.Text, out int letoRojstva))
            {
                ServiceReferenceSZ.Klub newKlub = new ServiceReferenceSZ.Klub
                { 
                    KlubID = Klub.KlubID,
                    Naziv = textBoxIme.Text,
                    Naslov = textBoxPriimek.Text,
                    LetoUstanovitve = letoRojstva
                };
                if (client.UpdateKlub(newKlub))
                    Klub = newKlub;
                else
                    MessageBox.Show("napaka pri posodabljanju podatkovne baze");
            }
            else
                MessageBox.Show("leto ustanovitve mora biti stevilo!");
        }

        private void button_brisi_strelec_Click(object sender, EventArgs e)
        {
            client.DeleteSVK(listBox1.SelectedValue.ToString());
            DetailsDialogKlub_Load(this, new EventArgs());
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DetailsDialogBridge ddb = new DetailsDialogBridge();
            ddb.IdSVK = int.Parse(listBox1.SelectedValue.ToString());
            ddb.ShowDialog();
            if(ddb.DialogResult == DialogResult.OK)
                DetailsDialogKlub_Load(this, new EventArgs());
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            toSort = 0;
            DetailsDialogKlub_Load(this, new EventArgs());
        }

        private void button_sort_priimek_Click(object sender, EventArgs e)
        {
            toSort = 1;
            DetailsDialogKlub_Load(this, new EventArgs());

        }

        private void button_sort_ime_Click(object sender, EventArgs e)
        {
            toSort = 2;
            DetailsDialogKlub_Load(this, new EventArgs());

        }
    }
}
