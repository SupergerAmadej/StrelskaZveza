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
    /// Interaction logic for DialogNewEntity.xaml
    /// </summary>
    public partial class DialogNewEntity : Window
    {
        public int Tip { get; set; }
        private static ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();
        public DialogNewEntity()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            if (Tip == 0)
            {
                if (int.TryParse(textBoxLrLu.Text, out int lr))
                {
                    ServiceReferenceSZ.Strelec s = new ServiceReferenceSZ.Strelec
                    {
                        Ime = textBoxIme.Text,
                        Priimek = textBoxPriimek.Text,
                        LetoRojstva = lr
                    };
                    client.AddStrelec(s, out int id);
                    this.DialogResult = true;

                }
                else
                    MessageBox.Show("Leto rojstva mora biti stevilo");
            }
            else
            {
                if (int.TryParse(textBoxLrLu.Text, out int lr))
                {
                    ServiceReferenceSZ.Klub k = new ServiceReferenceSZ.Klub
                    {
                        Naziv = textBoxIme.Text,
                        Naslov = textBoxPriimek.Text,
                        LetoUstanovitve = lr
                    };
                    client.AddKlub(k);
                    this.DialogResult = true;

                }
                else
                    MessageBox.Show("Leto ustanovitve mora biti stevilo");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Tip == 1)
            {
                labelImeNaziv.Content = "Naziv:";
                labelPriimekNaslov.Content = "Naslov:";
                labelLrLu.Content = "Leto ustanovitve:";
            }
        }
    }
}
