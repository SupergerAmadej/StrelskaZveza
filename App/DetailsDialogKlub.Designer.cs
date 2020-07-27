namespace App
{
    partial class DetailsDialogKlub
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
            this.button_brisi_strelec = new System.Windows.Forms.Button();
            this.label_v_klubih = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_shrani_podatke = new System.Windows.Forms.Button();
            this.textBoxLetoRojstva = new System.Windows.Forms.TextBox();
            this.textBoxPriimek = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label_leto_rojstva = new System.Windows.Forms.Label();
            this.labelPriimek = new System.Windows.Forms.Label();
            this.label_ime = new System.Windows.Forms.Label();
            this.button_sort = new System.Windows.Forms.Button();
            this.button_sort_ime = new System.Windows.Forms.Button();
            this.button_sort_priimek = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_brisi_strelec
            // 
            this.button_brisi_strelec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_brisi_strelec.Location = new System.Drawing.Point(130, 336);
            this.button_brisi_strelec.Name = "button_brisi_strelec";
            this.button_brisi_strelec.Size = new System.Drawing.Size(85, 23);
            this.button_brisi_strelec.TabIndex = 22;
            this.button_brisi_strelec.Text = "Izbrisi Strelca";
            this.button_brisi_strelec.UseVisualStyleBackColor = true;
            this.button_brisi_strelec.Click += new System.EventHandler(this.button_brisi_strelec_Click);
            // 
            // label_v_klubih
            // 
            this.label_v_klubih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_v_klubih.AutoSize = true;
            this.label_v_klubih.Location = new System.Drawing.Point(9, 115);
            this.label_v_klubih.Name = "label_v_klubih";
            this.label_v_klubih.Size = new System.Drawing.Size(128, 13);
            this.label_v_klubih.TabIndex = 21;
            this.label_v_klubih.Text = "Klub ima strelce: (aktivne)";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 199);
            this.listBox1.TabIndex = 20;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // button_shrani_podatke
            // 
            this.button_shrani_podatke.Location = new System.Drawing.Point(198, 95);
            this.button_shrani_podatke.Name = "button_shrani_podatke";
            this.button_shrani_podatke.Size = new System.Drawing.Size(92, 23);
            this.button_shrani_podatke.TabIndex = 19;
            this.button_shrani_podatke.Text = "Shrani podatke";
            this.button_shrani_podatke.UseVisualStyleBackColor = true;
            this.button_shrani_podatke.Click += new System.EventHandler(this.button_shrani_podatke_Click);
            // 
            // textBoxLetoRojstva
            // 
            this.textBoxLetoRojstva.Location = new System.Drawing.Point(105, 69);
            this.textBoxLetoRojstva.Name = "textBoxLetoRojstva";
            this.textBoxLetoRojstva.Size = new System.Drawing.Size(185, 20);
            this.textBoxLetoRojstva.TabIndex = 18;
            // 
            // textBoxPriimek
            // 
            this.textBoxPriimek.Location = new System.Drawing.Point(105, 38);
            this.textBoxPriimek.Name = "textBoxPriimek";
            this.textBoxPriimek.Size = new System.Drawing.Size(185, 20);
            this.textBoxPriimek.TabIndex = 17;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(105, 6);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(185, 20);
            this.textBoxIme.TabIndex = 16;
            // 
            // label_leto_rojstva
            // 
            this.label_leto_rojstva.AutoSize = true;
            this.label_leto_rojstva.Location = new System.Drawing.Point(12, 72);
            this.label_leto_rojstva.Name = "label_leto_rojstva";
            this.label_leto_rojstva.Size = new System.Drawing.Size(88, 13);
            this.label_leto_rojstva.TabIndex = 15;
            this.label_leto_rojstva.Text = "Leto Ustanovitve";
            // 
            // labelPriimek
            // 
            this.labelPriimek.AutoSize = true;
            this.labelPriimek.Location = new System.Drawing.Point(12, 41);
            this.labelPriimek.Name = "labelPriimek";
            this.labelPriimek.Size = new System.Drawing.Size(40, 13);
            this.labelPriimek.TabIndex = 14;
            this.labelPriimek.Text = "Naslov";
            // 
            // label_ime
            // 
            this.label_ime.AutoSize = true;
            this.label_ime.Location = new System.Drawing.Point(12, 9);
            this.label_ime.Name = "label_ime";
            this.label_ime.Size = new System.Drawing.Size(34, 13);
            this.label_ime.TabIndex = 13;
            this.label_ime.Text = "Naziv";
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(6, 77);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(75, 22);
            this.button_sort.TabIndex = 23;
            this.button_sort.Text = "starost";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // button_sort_ime
            // 
            this.button_sort_ime.Location = new System.Drawing.Point(6, 19);
            this.button_sort_ime.Name = "button_sort_ime";
            this.button_sort_ime.Size = new System.Drawing.Size(75, 23);
            this.button_sort_ime.TabIndex = 24;
            this.button_sort_ime.Text = "ime";
            this.button_sort_ime.UseVisualStyleBackColor = true;
            this.button_sort_ime.Click += new System.EventHandler(this.button_sort_ime_Click);
            // 
            // button_sort_priimek
            // 
            this.button_sort_priimek.Location = new System.Drawing.Point(6, 48);
            this.button_sort_priimek.Name = "button_sort_priimek";
            this.button_sort_priimek.Size = new System.Drawing.Size(75, 23);
            this.button_sort_priimek.TabIndex = 25;
            this.button_sort_priimek.Text = "priimek";
            this.button_sort_priimek.UseVisualStyleBackColor = true;
            this.button_sort_priimek.Click += new System.EventHandler(this.button_sort_priimek_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_sort_ime);
            this.groupBox1.Controls.Add(this.button_sort);
            this.groupBox1.Controls.Add(this.button_sort_priimek);
            this.groupBox1.Location = new System.Drawing.Point(221, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 104);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sortiranje";
            // 
            // DetailsDialogKlub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_brisi_strelec);
            this.Controls.Add(this.label_v_klubih);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_shrani_podatke);
            this.Controls.Add(this.textBoxLetoRojstva);
            this.Controls.Add(this.textBoxPriimek);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label_leto_rojstva);
            this.Controls.Add(this.labelPriimek);
            this.Controls.Add(this.label_ime);
            this.MinimumSize = new System.Drawing.Size(340, 420);
            this.Name = "DetailsDialogKlub";
            this.Text = "DetailsDialogKlub";
            this.Load += new System.EventHandler(this.DetailsDialogKlub_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_brisi_strelec;
        private System.Windows.Forms.Label label_v_klubih;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_shrani_podatke;
        private System.Windows.Forms.TextBox textBoxLetoRojstva;
        private System.Windows.Forms.TextBox textBoxPriimek;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label_leto_rojstva;
        private System.Windows.Forms.Label labelPriimek;
        private System.Windows.Forms.Label label_ime;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.Button button_sort_ime;
        private System.Windows.Forms.Button button_sort_priimek;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}