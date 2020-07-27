namespace App
{
    partial class DetailsDialogBridge
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
            this.label_od = new System.Windows.Forms.Label();
            this.label_do = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_od
            // 
            this.label_od.AutoSize = true;
            this.label_od.Location = new System.Drawing.Point(12, 19);
            this.label_od.Name = "label_od";
            this.label_od.Size = new System.Drawing.Size(24, 13);
            this.label_od.TabIndex = 0;
            this.label_od.Text = "Od:";
            // 
            // label_do
            // 
            this.label_do.AutoSize = true;
            this.label_do.Location = new System.Drawing.Point(12, 59);
            this.label_do.Name = "label_do";
            this.label_do.Size = new System.Drawing.Size(24, 13);
            this.label_do.TabIndex = 3;
            this.label_do.Text = "Do:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(42, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(151, 79);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(91, 23);
            this.button_reset.TabIndex = 6;
            this.button_reset.Text = "Pobriši";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(151, 109);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(91, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Shrani Podatke";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trenutno do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "(aktivn clan)";
            // 
            // DetailsDialogBridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 151);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_do);
            this.Controls.Add(this.label_od);
            this.MaximumSize = new System.Drawing.Size(280, 190);
            this.MinimumSize = new System.Drawing.Size(280, 190);
            this.Name = "DetailsDialogBridge";
            this.Text = "DetailsDialogBridge";
            this.Load += new System.EventHandler(this.DetailsDialogBridge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_od;
        private System.Windows.Forms.Label label_do;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}