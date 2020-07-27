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
    public partial class DetailsDialogBridge : Form
    {
        public DetailsDialogBridge()
        {
            InitializeComponent();
        }

        public int IdSVK { get; set; }
        private static ServiceReferenceSZ.StrelskaZvezaClient client = new ServiceReferenceSZ.StrelskaZvezaClient();
        private static ServiceReferenceSZ.StrelecVKlubu svk;

        private void DetailsDialogBridge_Load(object sender, EventArgs e)
        {
            button_save.DialogResult = DialogResult.OK;
            button_reset.DialogResult = DialogResult.OK;
            svk = client.ReturnStrelecVKlubus().SingleOrDefault(a => a.StrelecKlubID == IdSVK);
            dateTimePicker1.Value = svk.Od;
            if (svk.Do != null)
            {
                label1.Enabled = true;
                label2.Enabled = true;
                label2.Text = svk.Do.ToString();
                dateTimePicker2.Value = svk.Do.Value;
            }
            else
            {
                label1.Enabled = false;
                label2.Enabled = false;
                label2.Text = "(aktivn clan)";
            }

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < dateTimePicker2.Value && dateTimePicker1.Value < DateTime.Now)
            {
                svk.Od = dateTimePicker1.Value;
                svk.Do = dateTimePicker2.Value;
                client.UpdateSVK(svk);
                DetailsDialogBridge_Load(this, new EventArgs());
            }
            else
                MessageBox.Show("napacn format .. idk neki ne stima z datumi");
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Now;
            svk.Do = null;
            client.UpdateSVK(svk);
            DetailsDialogBridge_Load(this, new EventArgs());
        }
    }
}
