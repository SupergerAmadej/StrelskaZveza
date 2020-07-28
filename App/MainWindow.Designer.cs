namespace App
{
    partial class MainWindow
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
            this.button_log_out = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_dodaj_klub = new System.Windows.Forms.Button();
            this.button_dodaj_strelca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox_sort = new System.Windows.Forms.GroupBox();
            this.button_sort_lr = new System.Windows.Forms.Button();
            this.button_sort_priimek_lu = new System.Windows.Forms.Button();
            this.button_sort_ime_naziv = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_delete_selected = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_vsi_klubi = new System.Windows.Forms.Button();
            this.button_vsi_strelci = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_sort.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_log_out
            // 
            this.button_log_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_log_out.Location = new System.Drawing.Point(477, 12);
            this.button_log_out.Name = "button_log_out";
            this.button_log_out.Size = new System.Drawing.Size(75, 23);
            this.button_log_out.TabIndex = 0;
            this.button_log_out.Text = "Odjava";
            this.button_log_out.UseVisualStyleBackColor = true;
            this.button_log_out.Click += new System.EventHandler(this.button_log_out_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_dodaj_klub);
            this.groupBox1.Controls.Add(this.button_dodaj_strelca);
            this.groupBox1.Location = new System.Drawing.Point(359, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodajanje Primerkov";
            // 
            // button_dodaj_klub
            // 
            this.button_dodaj_klub.Location = new System.Drawing.Point(6, 61);
            this.button_dodaj_klub.Name = "button_dodaj_klub";
            this.button_dodaj_klub.Size = new System.Drawing.Size(75, 23);
            this.button_dodaj_klub.TabIndex = 1;
            this.button_dodaj_klub.Text = "Novi Klub";
            this.button_dodaj_klub.UseVisualStyleBackColor = true;
            this.button_dodaj_klub.Click += new System.EventHandler(this.button_dodaj_klub_Click);
            // 
            // button_dodaj_strelca
            // 
            this.button_dodaj_strelca.Location = new System.Drawing.Point(6, 32);
            this.button_dodaj_strelca.Name = "button_dodaj_strelca";
            this.button_dodaj_strelca.Size = new System.Drawing.Size(75, 23);
            this.button_dodaj_strelca.TabIndex = 0;
            this.button_dodaj_strelca.Text = "Novi Strelec";
            this.button_dodaj_strelca.UseVisualStyleBackColor = true;
            this.button_dodaj_strelca.Click += new System.EventHandler(this.button_dodaj_strelca_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox_sort);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 514);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox_sort
            // 
            this.groupBox_sort.Controls.Add(this.button_sort_lr);
            this.groupBox_sort.Controls.Add(this.button_sort_priimek_lu);
            this.groupBox_sort.Controls.Add(this.button_sort_ime_naziv);
            this.groupBox_sort.Location = new System.Drawing.Point(359, 161);
            this.groupBox_sort.Name = "groupBox_sort";
            this.groupBox_sort.Size = new System.Drawing.Size(89, 108);
            this.groupBox_sort.TabIndex = 7;
            this.groupBox_sort.TabStop = false;
            this.groupBox_sort.Text = "Sortiranje";
            // 
            // button_sort_lr
            // 
            this.button_sort_lr.Location = new System.Drawing.Point(6, 77);
            this.button_sort_lr.Name = "button_sort_lr";
            this.button_sort_lr.Size = new System.Drawing.Size(75, 23);
            this.button_sort_lr.TabIndex = 2;
            this.button_sort_lr.Text = "Leto rojstva";
            this.button_sort_lr.UseVisualStyleBackColor = true;
            this.button_sort_lr.Click += new System.EventHandler(this.button_sort_lr_Click);
            // 
            // button_sort_priimek_lu
            // 
            this.button_sort_priimek_lu.Location = new System.Drawing.Point(6, 48);
            this.button_sort_priimek_lu.Name = "button_sort_priimek_lu";
            this.button_sort_priimek_lu.Size = new System.Drawing.Size(75, 23);
            this.button_sort_priimek_lu.TabIndex = 1;
            this.button_sort_priimek_lu.Text = "Priimek";
            this.button_sort_priimek_lu.UseVisualStyleBackColor = true;
            this.button_sort_priimek_lu.Click += new System.EventHandler(this.button_sort_priimek_lu_Click);
            // 
            // button_sort_ime_naziv
            // 
            this.button_sort_ime_naziv.Location = new System.Drawing.Point(6, 19);
            this.button_sort_ime_naziv.Name = "button_sort_ime_naziv";
            this.button_sort_ime_naziv.Size = new System.Drawing.Size(75, 23);
            this.button_sort_ime_naziv.TabIndex = 0;
            this.button_sort_ime_naziv.Text = "Ime";
            this.button_sort_ime_naziv.UseVisualStyleBackColor = true;
            this.button_sort_ime_naziv.Click += new System.EventHandler(this.button_sort_ime_naziv_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_delete_selected);
            this.groupBox4.Location = new System.Drawing.Point(359, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(89, 59);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Brisanje Primerkov";
            // 
            // button_delete_selected
            // 
            this.button_delete_selected.Location = new System.Drawing.Point(6, 30);
            this.button_delete_selected.Name = "button_delete_selected";
            this.button_delete_selected.Size = new System.Drawing.Size(75, 23);
            this.button_delete_selected.TabIndex = 4;
            this.button_delete_selected.Text = "Izbrisi";
            this.button_delete_selected.UseVisualStyleBackColor = true;
            this.button_delete_selected.Click += new System.EventHandler(this.button_delete_selected_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_vsi_klubi);
            this.groupBox3.Controls.Add(this.button_vsi_strelci);
            this.groupBox3.Location = new System.Drawing.Point(359, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 83);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izpis";
            // 
            // button_vsi_klubi
            // 
            this.button_vsi_klubi.Location = new System.Drawing.Point(6, 19);
            this.button_vsi_klubi.Name = "button_vsi_klubi";
            this.button_vsi_klubi.Size = new System.Drawing.Size(75, 23);
            this.button_vsi_klubi.TabIndex = 1;
            this.button_vsi_klubi.Text = "Klubi";
            this.button_vsi_klubi.UseVisualStyleBackColor = true;
            this.button_vsi_klubi.Click += new System.EventHandler(this.button_vsi_klubi_Click);
            // 
            // button_vsi_strelci
            // 
            this.button_vsi_strelci.Location = new System.Drawing.Point(6, 48);
            this.button_vsi_strelci.Name = "button_vsi_strelci";
            this.button_vsi_strelci.Size = new System.Drawing.Size(75, 23);
            this.button_vsi_strelci.TabIndex = 2;
            this.button_vsi_strelci.Text = "Strelci";
            this.button_vsi_strelci.UseVisualStyleBackColor = true;
            this.button_vsi_strelci.Click += new System.EventHandler(this.button_vsi_strelci_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 485);
            this.listBox1.TabIndex = 3;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_log_out);
            this.MinimumSize = new System.Drawing.Size(580, 575);
            this.Name = "MainWindow";
            this.Text = "Glavno okno";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox_sort.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_log_out;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_dodaj_klub;
        private System.Windows.Forms.Button button_dodaj_strelca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_vsi_strelci;
        private System.Windows.Forms.Button button_vsi_klubi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_delete_selected;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_sort;
        private System.Windows.Forms.Button button_sort_lr;
        private System.Windows.Forms.Button button_sort_priimek_lu;
        private System.Windows.Forms.Button button_sort_ime_naziv;
    }
}