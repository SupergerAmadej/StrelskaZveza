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
    public partial class MainWindow : Form
    {
        private static ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();
        private static List<ServiceReferenceSZ.Klub> klubs = new List<ServiceReferenceSZ.Klub>();
        private static List<ServiceReferenceSZ.Strelec> Strelecs = new List<ServiceReferenceSZ.Strelec>();
        private static int lastLoaded = -1;
        private static int sort = -1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_vsi_klubi_Click(object sender, EventArgs e)
        {

            klubs = client.ReturnKlubi().ToList();

            if (sort == 0)
                klubs = klubs.OrderBy(a => a.Naziv).ToList();
            else if (sort == 1)
                klubs = klubs.OrderByDescending(a => a.LetoUstanovitve).ToList();

            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DisplayMember = "Naziv";
            listBox1.ValueMember = "KlubID";

            listBox1.DataSource = klubs;
            lastLoaded = 0;
            sort = -1;
            MainWindow_Load(this, new EventArgs());

        }

        private void button_vsi_strelci_Click(object sender, EventArgs e)
        {
            Strelecs = client.ReturnStrelci().ToList();

            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DisplayMember= "Ime";
            listBox1.ValueMember = "StrelecID";

            if (sort == 0)
                Strelecs = Strelecs.OrderBy(a => a.Ime).ToList();
            else if (sort == 1)
                Strelecs = Strelecs.OrderBy(a => a.Priimek).ToList();
            else if (sort == 2)
                Strelecs = Strelecs.OrderByDescending(a => a.LetoRojstva).ToList();

            var strelci = (from a in Strelecs
                       select new
                       {
                           Ime = a.Ime + " " + a.Priimek,
                           StrelecID = a.StrelecID
                       }).ToList();

            listBox1.DataSource = strelci;
            lastLoaded = 1;
            sort = -1;
            MainWindow_Load(this, new EventArgs());

        }

        private void UpdateList()
        {
            if(listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem.GetType().Name.Equals("Klub"))
                    button_vsi_klubi_Click(this, new EventArgs());
                else
                    button_vsi_strelci_Click(this, new EventArgs());
            }

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem.GetType().Name.Equals("Klub"))
            {
                DetailsDialogKlub ddk = new DetailsDialogKlub();
                ddk.Item = listBox1.SelectedValue.ToString();
                ddk.ShowDialog();
                if (ddk.DialogResult == DialogResult.OK)
                    UpdateList();
            }
            else
            {
                DetailsDialogStrelec dds = new DetailsDialogStrelec();
                dds.Item = listBox1.SelectedValue.ToString();
                dds.ShowDialog();
                if (dds.DialogResult == DialogResult.OK)
                    UpdateList();
            }
        }

        private void button_dodaj_strelca_Click(object sender, EventArgs e)
        {
            DialogNewEntity dne = new DialogNewEntity();
            dne.Tip = 0;
            dne.ShowDialog();
            if (dne.DialogResult == DialogResult.OK)
                UpdateList();
        }

        private void button_dodaj_klub_Click(object sender, EventArgs e)
        {
            DialogNewEntity dne = new DialogNewEntity();
            dne.Tip = 1;
            dne.ShowDialog();
            if (dne.DialogResult == DialogResult.OK)
                UpdateList();

        }

        private void button_delete_selected_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (lastLoaded == 0)
                    client.DeleteKlub(listBox1.SelectedValue.ToString());
                else if (lastLoaded == 1)
                    client.DeleteStrelec(listBox1.SelectedValue.ToString());
                UpdateList();
                MessageBox.Show("Zbrisan");
            }
            else
                MessageBox.Show("Izbran mora biti nek item");
        }

        private void button_log_out_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (lastLoaded != -1)
            {
                groupBox_sort.Enabled = true;
                groupBox_sort.Visible = true;

                if (lastLoaded == 0) //klubi
                {
                    button_sort_ime_naziv.Text = "Naziv";
                    button_sort_priimek_lu.Text = "Leto ust.";
                    button_sort_lr.Visible = false;
                    button_sort_lr.Enabled = false;
                }
                else //strelci
                {
                    button_sort_ime_naziv.Text = "Ime";
                    button_sort_priimek_lu.Text = "Priimek";
                    button_sort_lr.Enabled = true;
                    button_sort_lr.Visible = true;
                    button_sort_lr.Text = "Leto rojstva";
                }
            }
            else
            {
                groupBox_sort.Enabled = false;
                groupBox_sort.Visible = false;
            }

        }

        private void button_sort_ime_naziv_Click(object sender, EventArgs e)
        {
            sort = 0;
            if (lastLoaded == 0)
                button_vsi_klubi_Click(this, new EventArgs());
            else
                button_vsi_strelci_Click(this, new EventArgs());
        }

        private void button_sort_priimek_lu_Click(object sender, EventArgs e)
        {
            sort = 1;
            if (lastLoaded == 0)
                button_vsi_klubi_Click(this, new EventArgs());
            else
                button_vsi_strelci_Click(this, new EventArgs());
        }

        private void button_sort_lr_Click(object sender, EventArgs e)
        {
            sort = 2;
            if (lastLoaded == 1)
                button_vsi_strelci_Click(this, new EventArgs());
        }
    }
}
