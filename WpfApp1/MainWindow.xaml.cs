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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (lastLoaded != -1)
            {
                groupBox_sort.IsEnabled = true;
                //groupBox_sort.IsVisible = true;

                if (lastLoaded == 0) //klubi
                {
                    radioButtonImeNaziv.Content = "Naziv";
                    radioButtonPriimekNaslov.Content = "Leto ust.";
                    //radioButtonLeto.Visible = false;
                    radioButtonLeto.IsEnabled = false;
                }
                else //strelci
                {
                    radioButtonImeNaziv.Content = "Ime";
                    radioButtonPriimekNaslov.Content = "Priimek";
                    radioButtonLeto.IsEnabled = true;
                    //radioButtonLeto.Visible = true;
                    radioButtonLeto.Content = "Leto rojstva";
                }
            }
            else
            {
                groupBox_sort.IsEnabled = false;
                //groupBox_sort.Visible = false;
            }
        }

        private void radioButtonKlubi_Checked(object sender, RoutedEventArgs e)
        {
            klubs = client.ReturnKlubi().ToList();

            if (sort == 0)
                klubs = klubs.OrderBy(a => a.Naziv).ToList();
            else if (sort == 1)
                klubs = klubs.OrderByDescending(a => a.LetoUstanovitve).ToList();

            //listBox.DataSource = null;
            listBox.ItemsSource = null;
            //listBox.Items.Clear();
            //listBox.DisplayMember = "Naziv";
            //listBox.ValueMember = "KlubID";
            listBox.DisplayMemberPath = "Naziv";
            listBox.SelectedValuePath = "KlubID";

            //listBox.DataSource = klubs;
            listBox.ItemsSource = klubs;
            lastLoaded = 0;
            sort = -1;
            Window_Loaded(this, new RoutedEventArgs());
        }

        private void radioButtonStrelci_Checked(object sender, RoutedEventArgs e)
        {
            Strelecs = client.ReturnStrelci().ToList();
            listBox.ItemsSource = null;
            //listBox.Items.Clear();
            listBox.DisplayMemberPath = "Ime";
            listBox.SelectedValuePath = "StrelecID";

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

            listBox.ItemsSource = strelci;
            lastLoaded = 1;
            sort = -1;
            Window_Loaded(this, new RoutedEventArgs());
        }

        private void UpdateList()
        {
            if (listBox.Items[0] != null)
            {
                if (listBox.Items[0].GetType().Name.Equals("Klub"))
                    radioButtonKlubi_Checked(this, new RoutedEventArgs());
                else
                    radioButtonStrelci_Checked(this, new RoutedEventArgs());
            }

        }

        private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listBox.SelectedItems.Count == 1)
            {
                if (listBox.SelectedItem.GetType().Name.Equals("Klub"))
                {
                    DetailsDialogKlub ddk = new DetailsDialogKlub();
                    ddk.Item = listBox.SelectedValue.ToString();
                    ddk.ShowDialog();
                    if (ddk.DialogResult == true)
                        UpdateList();
                }
                else
                {
                    DetailsDialogStrelec dds = new DetailsDialogStrelec();
                    dds.Item = listBox.SelectedValue.ToString();
                    dds.ShowDialog();
                    if (dds.DialogResult == true)
                        UpdateList();
                }
            }

        }

        private void buttonNoviStrelec_Click(object sender, RoutedEventArgs e)
        {
            DialogNewEntity dne = new DialogNewEntity();
            dne.Tip = 0;
            dne.ShowDialog();
            if (dne.DialogResult == true)
                UpdateList();
        }

        private void buttonNoviKlub_Click(object sender, RoutedEventArgs e)
        {
            DialogNewEntity dne = new DialogNewEntity();
            dne.Tip = 1;
            dne.ShowDialog();
            if (dne.DialogResult == true)
                UpdateList();
        }

        private void buttonBrisi_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                if (lastLoaded == 0)
                    client.DeleteKlub(listBox.SelectedValue.ToString());
                else if (lastLoaded == 1)
                    client.DeleteStrelec(listBox.SelectedValue.ToString());
                UpdateList();
                MessageBox.Show("Zbrisan");
            }
            else
                MessageBox.Show("Izbran mora biti nek item");
        }

        private void buttonLogout_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void radioButtonImeNaziv_Checked(object sender, RoutedEventArgs e)
        {
            sort = 0;
            if (lastLoaded == 0)
                radioButtonKlubi_Checked(this, new RoutedEventArgs());
            else
                radioButtonStrelci_Checked(this, new RoutedEventArgs());
        }

        private void radioButtonPriimekNaslov_Checked(object sender, RoutedEventArgs e)
        {
            sort = 1; //letu ustanovitve ne naslov
            if (lastLoaded == 0)
                radioButtonKlubi_Checked(this, new RoutedEventArgs());
            else
                radioButtonStrelci_Checked(this, new RoutedEventArgs());
        }

        private void radioButtonLeto_Checked(object sender, RoutedEventArgs e)
        {
            sort = 2;
            if (lastLoaded == 1)
                radioButtonStrelci_Checked(this, new RoutedEventArgs());
        }

        private void UserControlSortiranjeStrelec_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
