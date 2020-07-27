namespace App
{
    partial class Prijava
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
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelUporabniskoIme = new System.Windows.Forms.Label();
            this.labelGeslo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(95, 143);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(75, 23);
            this.buttonPrijava.TabIndex = 0;
            this.buttonPrijava.Text = "Prijavi";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // labelUporabniskoIme
            // 
            this.labelUporabniskoIme.AutoSize = true;
            this.labelUporabniskoIme.Location = new System.Drawing.Point(83, 42);
            this.labelUporabniskoIme.Name = "labelUporabniskoIme";
            this.labelUporabniskoIme.Size = new System.Drawing.Size(87, 13);
            this.labelUporabniskoIme.TabIndex = 3;
            this.labelUporabniskoIme.Text = "Uporabnisko Ime";
            // 
            // labelGeslo
            // 
            this.labelGeslo.AutoSize = true;
            this.labelGeslo.Location = new System.Drawing.Point(83, 92);
            this.labelGeslo.Name = "labelGeslo";
            this.labelGeslo.Size = new System.Drawing.Size(34, 13);
            this.labelGeslo.TabIndex = 4;
            this.labelGeslo.Text = "Geslo";
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 249);
            this.Controls.Add(this.labelGeslo);
            this.Controls.Add(this.labelUporabniskoIme);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonPrijava);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelUporabniskoIme;
        private System.Windows.Forms.Label labelGeslo;
    }
}

