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
    /// Interaction logic for DetailsDialogKlub.xaml
    /// </summary>
    /// 


    public partial class DetailsDialogKlub : Window
    {
        public string Item { get; set; }

        private ServiceReferenceSZ.Klub Klub { get; set; }
        private static ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();

        private static int toSort = -1;

        public DetailsDialogKlub()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Klub = client.GetKlub(Item);

            //buttonSave.DialogResult = DialogResult.OK;

            textBoxIme.Text = Klub.Naziv;
            textBoxPriimek.Text = Klub.Naslov;
            textBoxLetoRojstva.Text = Klub.LetoUstanovitve.ToString();

            var strelci = client.ReturnStrelecVKlubus();
            var klubiStrelec = strelci.Where(a => a.Klub.KlubID == Klub.KlubID).ToList();
            klubiStrelec.Where(a => a.Do != null).ToList().ForEach(a => a.Strelec.Priimek = a.Strelec.Priimek + " **"); //veri ugly lol

            if (toSort == 0) //sort
                klubiStrelec = klubiStrelec.OrderByDescending(a => a.Strelec.LetoRojstva).ToList();
            else if (toSort == 1)
                klubiStrelec = klubiStrelec.OrderBy(a => a.Strelec.Priimek).ToList();
            else if (toSort == 2)
                klubiStrelec = klubiStrelec.OrderBy(a => a.Strelec.Ime).ToList();


            var cStrelecKlubi = (from a in klubiStrelec
                                 select new
                                 {
                                     Naziv = a.Strelec.Ime + " " + a.Strelec.Priimek,
                                     StrelecKlubID = a.StrelecKlubID
                                 }).ToList();

            listBox.ItemsSource = null;
            listBox.DisplayMemberPath = "Naziv";
            listBox.SelectedValuePath = "StrelecKlubID";
            listBox.ItemsSource = cStrelecKlubi;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
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

        private void buttonDeleteStrelec_Click(object sender, RoutedEventArgs e)
        {

            if (listBox.SelectedItems.Count == 1)
            {
                client.DeleteSVK(listBox.SelectedValue.ToString());
                Window_Loaded(this, new RoutedEventArgs());
            }

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

        private void buttonSortIme_Click(object sender, RoutedEventArgs e)
        {
            toSort = 0;
            Window_Loaded(this, new RoutedEventArgs());

        }

        private void buttonSortPriimek_Click(object sender, RoutedEventArgs e)
        {
            toSort = 1;
            Window_Loaded(this, new RoutedEventArgs());

        }

        private void buttonSortStarost_Click(object sender, RoutedEventArgs e)
        {
            toSort = 2;
            Window_Loaded(this, new RoutedEventArgs());

        }
    }
}
