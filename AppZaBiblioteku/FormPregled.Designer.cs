namespace AppZaBiblioteku
{
    partial class FormPregled
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
            this.BTNpregledaj = new System.Windows.Forms.Button();
            this.LBLidKnjige = new System.Windows.Forms.Label();
            this.TXTidKnjige = new System.Windows.Forms.TextBox();
            this.LBLidKorisnika = new System.Windows.Forms.Label();
            this.TXTidKorisnika = new System.Windows.Forms.TextBox();
            this.LBLunesiPodatke = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNpregledaj
            // 
            this.BTNpregledaj.Location = new System.Drawing.Point(73, 169);
            this.BTNpregledaj.Name = "BTNpregledaj";
            this.BTNpregledaj.Size = new System.Drawing.Size(76, 23);
            this.BTNpregledaj.TabIndex = 11;
            this.BTNpregledaj.Text = "Pregledaj";
            this.BTNpregledaj.UseVisualStyleBackColor = true;
            this.BTNpregledaj.Click += new System.EventHandler(this.BTNpregledaj_Click);
            // 
            // LBLidKnjige
            // 
            this.LBLidKnjige.AutoSize = true;
            this.LBLidKnjige.Location = new System.Drawing.Point(22, 107);
            this.LBLidKnjige.Name = "LBLidKnjige";
            this.LBLidKnjige.Size = new System.Drawing.Size(52, 13);
            this.LBLidKnjige.TabIndex = 10;
            this.LBLidKnjige.Text = "ID knjige:";
            // 
            // TXTidKnjige
            // 
            this.TXTidKnjige.Location = new System.Drawing.Point(19, 126);
            this.TXTidKnjige.Name = "TXTidKnjige";
            this.TXTidKnjige.Size = new System.Drawing.Size(187, 20);
            this.TXTidKnjige.TabIndex = 9;
            // 
            // LBLidKorisnika
            // 
            this.LBLidKorisnika.AutoSize = true;
            this.LBLidKorisnika.Location = new System.Drawing.Point(22, 49);
            this.LBLidKorisnika.Name = "LBLidKorisnika";
            this.LBLidKorisnika.Size = new System.Drawing.Size(66, 13);
            this.LBLidKorisnika.TabIndex = 8;
            this.LBLidKorisnika.Text = "ID korisnika:";
            // 
            // TXTidKorisnika
            // 
            this.TXTidKorisnika.Location = new System.Drawing.Point(19, 68);
            this.TXTidKorisnika.Name = "TXTidKorisnika";
            this.TXTidKorisnika.Size = new System.Drawing.Size(187, 20);
            this.TXTidKorisnika.TabIndex = 7;
            // 
            // LBLunesiPodatke
            // 
            this.LBLunesiPodatke.AutoSize = true;
            this.LBLunesiPodatke.Location = new System.Drawing.Point(70, 18);
            this.LBLunesiPodatke.Name = "LBLunesiPodatke";
            this.LBLunesiPodatke.Size = new System.Drawing.Size(79, 13);
            this.LBLunesiPodatke.TabIndex = 6;
            this.LBLunesiPodatke.Text = "Unesi podatke:";
            // 
            // FormPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 211);
            this.Controls.Add(this.BTNpregledaj);
            this.Controls.Add(this.LBLidKnjige);
            this.Controls.Add(this.TXTidKnjige);
            this.Controls.Add(this.LBLidKorisnika);
            this.Controls.Add(this.TXTidKorisnika);
            this.Controls.Add(this.LBLunesiPodatke);
            this.Name = "FormPregled";
            this.Text = "FormPregled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNpregledaj;
        private System.Windows.Forms.Label LBLidKnjige;
        private System.Windows.Forms.TextBox TXTidKnjige;
        private System.Windows.Forms.Label LBLidKorisnika;
        private System.Windows.Forms.TextBox TXTidKorisnika;
        private System.Windows.Forms.Label LBLunesiPodatke;
    }
}