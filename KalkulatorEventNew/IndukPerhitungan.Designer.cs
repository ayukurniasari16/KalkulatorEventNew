
namespace KalkulatorEventNew
{
    partial class IndukPerhitungan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Hasil = new System.Windows.Forms.ListBox();
            this.Hitung = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Hasil);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasil";
            // 
            // Hasil
            // 
            this.Hasil.FormattingEnabled = true;
            this.Hasil.Location = new System.Drawing.Point(6, 19);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(345, 342);
            this.Hasil.TabIndex = 0;
            // 
            // Hitung
            // 
            this.Hitung.Location = new System.Drawing.Point(12, 397);
            this.Hitung.Name = "Hitung";
            this.Hitung.Size = new System.Drawing.Size(357, 41);
            this.Hitung.TabIndex = 1;
            this.Hitung.Text = "Hitung";
            this.Hitung.UseVisualStyleBackColor = true;
            this.Hitung.Click += new System.EventHandler(this.Hitung_Click);
            // 
            // IndukPerhitungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.Hitung);
            this.Controls.Add(this.groupBox1);
            this.Name = "IndukPerhitungan";
            this.Text = "Induk Perhitungan";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Hasil;
        private System.Windows.Forms.Button Hitung;
    }
}

