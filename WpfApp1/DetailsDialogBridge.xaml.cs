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
    /// Interaction logic for DetailsDialogBridge.xaml
    /// </summary>
    public partial class DetailsDialogBridge : Window
    {
        public int IdSVK { get; set; }
        private static ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();
        private static ServiceReferenceSZ.StrelecVKlubu svk;

        public DetailsDialogBridge()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            svk = client.ReturnStrelecVKlubus().SingleOrDefault(a => a.StrelecKlubID == IdSVK);
            datePickerOd.SelectedDate = svk.Od;
            if (svk.Do != null)
            {
                label3.IsEnabled = true;
                label2.IsEnabled = true;
                label2.Content = svk.Do.ToString();
                datePickerDo.SelectedDate = svk.Do.Value;
            }
            else
            {
                label3.IsEnabled = false;
                label2.IsEnabled = false;
                label2.Content = "(aktivn clan)";
            }
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            if (datePickerOd.SelectedDate < datePickerDo.SelectedDate && datePickerOd.SelectedDate < DateTime.Now)
            {
                svk.Od = (DateTime)datePickerOd.SelectedDate;
                svk.Do = datePickerDo.SelectedDate;
                client.UpdateSVK(svk);
                Window_Loaded(this, new RoutedEventArgs());
                this.DialogResult = true;
            }
            else
                MessageBox.Show("napacn format .. idk neki ne stima z datumi");
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            datePickerDo.SelectedDate = DateTime.Now;
            svk.Do = null;
            client.UpdateSVK(svk);
            Window_Loaded(this, new RoutedEventArgs());
            this.DialogResult = true;
        }
    }
}
