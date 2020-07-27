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
    /// Interaction logic for DetailsDialogStrelec.xaml
    /// </summary>
    public partial class DetailsDialogStrelec : Window
    {
        public string Item { get; set; }

        private ServiceReferenceSZ.Strelec Strelec { get; set; }
        private static ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();
        public DetailsDialogStrelec()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
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
                {
                    Strelec = newStrelec;
                    this.DialogResult = true;
                }
                else
                    MessageBox.Show("napaka pri posodabljanju podatkovne baze");
            }
            else
                MessageBox.Show("leto rojstva mora biti stevilo!");
        }

        private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listBox.SelectedItems.Count == 1)
            {
                DetailsDialogBridge ddb = new DetailsDialogBridge();
                ddb.IdSVK = int.Parse(listBox.SelectedValue.ToString());
                ddb.ShowDialog();
                if (ddb.DialogResult == true)
                    Window_Loaded(this, new RoutedEventArgs());
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Strelec = client.GetStrelec(Item);

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

            listBox.ItemsSource = null;
            listBox.DisplayMemberPath = "Naziv";
            listBox.SelectedValuePath = "StrelecKlubID";
            listBox.ItemsSource = cStrelecKlubi;


            List<ServiceReferenceSZ.Klub> vsiKlubi = new List<ServiceReferenceSZ.Klub>();
            vsiKlubi = client.ReturnKlubi().ToList();
            listBox1.ItemsSource = null;
            listBox1.DisplayMemberPath = "Naziv";
            listBox1.SelectedValuePath = "KlubID";
            listBox1.ItemsSource = vsiKlubi;
        }

        private void buttonDeleteKlub_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItems.Count == 1)
            {
                client.DeleteSVK(listBox.SelectedValue.ToString());
                Window_Loaded(this, new RoutedEventArgs());
            }


        }

        private void buttonAddKlub_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                client.DodajStrelcaVklub(Strelec, listBox1.SelectedValue.ToString());
                Window_Loaded(this, new RoutedEventArgs());
            }


        }
    }
}
