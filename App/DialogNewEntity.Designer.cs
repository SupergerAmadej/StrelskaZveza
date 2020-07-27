namespace App
{
    partial class DialogNewEntity
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
            this.label_ime_naziv = new System.Windows.Forms.Label();
            this.label_naslov_priimek = new System.Windows.Forms.Label();
            this.label_lr_lr = new System.Windows.Forms.Label();
            this.textBox_ime = new System.Windows.Forms.TextBox();
            this.textBox_priimek = new System.Windows.Forms.TextBox();
            this.textBox_lr = new System.Windows.Forms.TextBox();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ime_naziv
            // 
            this.label_ime_naziv.AutoSize = true;
            this.label_ime_naziv.Location = new System.Drawing.Point(12, 9);
            this.label_ime_naziv.Name = "label_ime_naziv";
            this.label_ime_naziv.Size = new System.Drawing.Size(27, 13);
            this.label_ime_naziv.TabIndex = 0;
            this.label_ime_naziv.Text = "Ime:";
            // 
            // label_naslov_priimek
            // 
            this.label_naslov_priimek.AutoSize = true;
            this.label_naslov_priimek.Location = new System.Drawing.Point(12, 42);
            this.label_naslov_priimek.Name = "label_naslov_priimek";
            this.label_naslov_priimek.Size = new System.Drawing.Size(44, 13);
            this.label_naslov_priimek.TabIndex = 1;
            this.label_naslov_priimek.Text = "Priimek:";
            // 
            // label_lr_lr
            // 
            this.label_lr_lr.AutoSize = true;
            this.label_lr_lr.Location = new System.Drawing.Point(12, 73);
            this.label_lr_lr.Name = "label_lr_lr";
            this.label_lr_lr.Size = new System.Drawing.Size(65, 13);
            this.label_lr_lr.TabIndex = 2;
            this.label_lr_lr.Text = "Leto rojstva:";
            // 
            // textBox_ime
            // 
            this.textBox_ime.Location = new System.Drawing.Point(111, 6);
            this.textBox_ime.Name = "textBox_ime";
            this.textBox_ime.Size = new System.Drawing.Size(184, 20);
            this.textBox_ime.TabIndex = 3;
            // 
            // textBox_priimek
            // 
            this.textBox_priimek.Location = new System.Drawing.Point(111, 39);
            this.textBox_priimek.Name = "textBox_priimek";
            this.textBox_priimek.Size = new System.Drawing.Size(184, 20);
            this.textBox_priimek.TabIndex = 4;
            // 
            // textBox_lr
            // 
            this.textBox_lr.Location = new System.Drawing.Point(111, 70);
            this.textBox_lr.Name = "textBox_lr";
            this.textBox_lr.Size = new System.Drawing.Size(184, 20);
            this.textBox_lr.TabIndex = 5;
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(219, 97);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(75, 23);
            this.button_dodaj.TabIndex = 6;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // DialogNewEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 126);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.textBox_lr);
            this.Controls.Add(this.textBox_priimek);
            this.Controls.Add(this.textBox_ime);
            this.Controls.Add(this.label_lr_lr);
            this.Controls.Add(this.label_naslov_priimek);
            this.Controls.Add(this.label_ime_naziv);
            this.MinimumSize = new System.Drawing.Size(325, 165);
            this.Name = "DialogNewEntity";
            this.Text = "Dialog";
            this.Load += new System.EventHandler(this.DialogNewEntity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ime_naziv;
        private System.Windows.Forms.Label label_naslov_priimek;
        private System.Windows.Forms.Label label_lr_lr;
        private System.Windows.Forms.TextBox textBox_ime;
        private System.Windows.Forms.TextBox textBox_priimek;
        private System.Windows.Forms.TextBox textBox_lr;
        private System.Windows.Forms.Button button_dodaj;
    }
}