namespace App
{
    partial class DetailsDialogStrelec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_ime = new System.Windows.Forms.Label();
            this.labelPriimek = new System.Windows.Forms.Label();
            this.label_leto_rojstva = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPriimek = new System.Windows.Forms.TextBox();
            this.textBoxLetoRojstva = new System.Windows.Forms.TextBox();
            this.button_shrani_podatke = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_v_klubih = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button_dodaj_klub = new System.Windows.Forms.Button();
            this.button_brisi_klub = new System.Windows.Forms.Button();
            this.label_seznam_klubov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ime
            // 
            this.label_ime.AutoSize = true;
            this.label_ime.Location = new System.Drawing.Point(12, 20);
            this.label_ime.Name = "label_ime";
            this.label_ime.Size = new System.Drawing.Size(24, 13);
            this.label_ime.TabIndex = 1;
            this.label_ime.Text = "Ime";
            // 
            // labelPriimek
            // 
            this.labelPriimek.AutoSize = true;
            this.labelPriimek.Location = new System.Drawing.Point(12, 52);
            this.labelPriimek.Name = "labelPriimek";
            this.labelPriimek.Size = new System.Drawing.Size(41, 13);
            this.labelPriimek.TabIndex = 2;
            this.labelPriimek.Text = "Priimek";
            // 
            // label_leto_rojstva
            // 
            this.label_leto_rojstva.AutoSize = true;
            this.label_leto_rojstva.Location = new System.Drawing.Point(12, 83);
            this.label_leto_rojstva.Name = "label_leto_rojstva";
            this.label_leto_rojstva.Size = new System.Drawing.Size(62, 13);
            this.label_leto_rojstva.TabIndex = 3;
            this.label_leto_rojstva.Text = "Leto rojstva";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(80, 17);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(185, 20);
            this.textBoxIme.TabIndex = 4;
            // 
            // textBoxPriimek
            // 
            this.textBoxPriimek.Location = new System.Drawing.Point(80, 49);
            this.textBoxPriimek.Name = "textBoxPriimek";
            this.textBoxPriimek.Size = new System.Drawing.Size(185, 20);
            this.textBoxPriimek.TabIndex = 5;
            // 
            // textBoxLetoRojstva
            // 
            this.textBoxLetoRojstva.Location = new System.Drawing.Point(80, 80);
            this.textBoxLetoRojstva.Name = "textBoxLetoRojstva";
            this.textBoxLetoRojstva.Size = new System.Drawing.Size(185, 20);
            this.textBoxLetoRojstva.TabIndex = 6;
            // 
            // button_shrani_podatke
            // 
            this.button_shrani_podatke.Location = new System.Drawing.Point(173, 106);
            this.button_shrani_podatke.Name = "button_shrani_podatke";
            this.button_shrani_podatke.Size = new System.Drawing.Size(92, 23);
            this.button_shrani_podatke.TabIndex = 7;
            this.button_shrani_podatke.Text = "Shrani podatke";
            this.button_shrani_podatke.UseVisualStyleBackColor = true;
            this.button_shrani_podatke.Click += new System.EventHandler(this.button_shrani_podatke_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 211);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 199);
            this.listBox1.TabIndex = 8;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // label_v_klubih
            // 
            this.label_v_klubih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_v_klubih.AutoSize = true;
            this.label_v_klubih.Location = new System.Drawing.Point(9, 195);
            this.label_v_klubih.Name = "label_v_klubih";
            this.label_v_klubih.Size = new System.Drawing.Size(241, 13);
            this.label_v_klubih.TabIndex = 9;
            this.label_v_klubih.Text = "Strelec je v naslednjih klubih: (** trenutno aktiven)";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(281, 211);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(211, 199);
            this.listBox2.TabIndex = 10;
            // 
            // button_dodaj_klub
            // 
            this.button_dodaj_klub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_dodaj_klub.Location = new System.Drawing.Point(417, 416);
            this.button_dodaj_klub.Name = "button_dodaj_klub";
            this.button_dodaj_klub.Size = new System.Drawing.Size(75, 23);
            this.button_dodaj_klub.TabIndex = 11;
            this.button_dodaj_klub.Text = "Dodaj Klub";
            this.button_dodaj_klub.UseVisualStyleBackColor = true;
            this.button_dodaj_klub.Click += new System.EventHandler(this.button_dodaj_klub_Click);
            // 
            // button_brisi_klub
            // 
            this.button_brisi_klub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_brisi_klub.Location = new System.Drawing.Point(140, 416);
            this.button_brisi_klub.Name = "button_brisi_klub";
            this.button_brisi_klub.Size = new System.Drawing.Size(75, 23);
            this.button_brisi_klub.TabIndex = 12;
            this.button_brisi_klub.Text = "Izbrisi Klub";
            this.button_brisi_klub.UseVisualStyleBackColor = true;
            this.button_brisi_klub.Click += new System.EventHandler(this.button_brisi_klub_Click);
            // 
            // label_seznam_klubov
            // 
            this.label_seznam_klubov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_seznam_klubov.AutoSize = true;
            this.label_seznam_klubov.Location = new System.Drawing.Point(278, 195);
            this.label_seznam_klubov.Name = "label_seznam_klubov";
            this.label_seznam_klubov.Size = new System.Drawing.Size(109, 13);
            this.label_seznam_klubov.TabIndex = 13;
            this.label_seznam_klubov.Text = "Seznam vseh klubov:";
            // 
            // DetailsDialogStrelec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 451);
            this.Controls.Add(this.label_seznam_klubov);
            this.Controls.Add(this.button_brisi_klub);
            this.Controls.Add(this.button_dodaj_klub);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label_v_klubih);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_shrani_podatke);
            this.Controls.Add(this.textBoxLetoRojstva);
            this.Controls.Add(this.textBoxPriimek);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label_leto_rojstva);
            this.Controls.Add(this.labelPriimek);
            this.Controls.Add(this.label_ime);
            this.MinimumSize = new System.Drawing.Size(520, 490);
            this.Name = "DetailsDialogStrelec";
            this.Text = " ";
            this.Load += new System.EventHandler(this.DetailsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ime;
        private System.Windows.Forms.Label labelPriimek;
        private System.Windows.Forms.Label label_leto_rojstva;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPriimek;
        private System.Windows.Forms.TextBox textBoxLetoRojstva;
        private System.Windows.Forms.Button button_shrani_podatke;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_v_klubih;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button_dodaj_klub;
        private System.Windows.Forms.Button button_brisi_klub;
        private System.Windows.Forms.Label label_seznam_klubov;
    }
}