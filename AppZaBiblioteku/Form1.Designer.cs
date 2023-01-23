namespace AppZaBiblioteku
{
    partial class Form1
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
            this.BTNunos = new System.Windows.Forms.Button();
            this.BTNnoviKorisnik = new System.Windows.Forms.Button();
            this.BTNpregled = new System.Windows.Forms.Button();
            this.BTNnovaKnjiga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNunos
            // 
            this.BTNunos.Location = new System.Drawing.Point(13, 138);
            this.BTNunos.Name = "BTNunos";
            this.BTNunos.Size = new System.Drawing.Size(167, 48);
            this.BTNunos.TabIndex = 0;
            this.BTNunos.Text = "Unos";
            this.BTNunos.UseVisualStyleBackColor = true;
            this.BTNunos.Click += new System.EventHandler(this.BTNunos_Click);
            // 
            // BTNnoviKorisnik
            // 
            this.BTNnoviKorisnik.Location = new System.Drawing.Point(13, 12);
            this.BTNnoviKorisnik.Name = "BTNnoviKorisnik";
            this.BTNnoviKorisnik.Size = new System.Drawing.Size(167, 48);
            this.BTNnoviKorisnik.TabIndex = 1;
            this.BTNnoviKorisnik.Text = "Novi korisnik";
            this.BTNnoviKorisnik.UseVisualStyleBackColor = true;
            this.BTNnoviKorisnik.Click += new System.EventHandler(this.BTNnoviKorisnik_Click_1);
            // 
            // BTNpregled
            // 
            this.BTNpregled.Location = new System.Drawing.Point(13, 202);
            this.BTNpregled.Name = "BTNpregled";
            this.BTNpregled.Size = new System.Drawing.Size(167, 48);
            this.BTNpregled.TabIndex = 2;
            this.BTNpregled.Text = "Pregled";
            this.BTNpregled.UseVisualStyleBackColor = true;
            this.BTNpregled.Click += new System.EventHandler(this.BTNpregled_Click);
            // 
            // BTNnovaKnjiga
            // 
            this.BTNnovaKnjiga.Location = new System.Drawing.Point(13, 75);
            this.BTNnovaKnjiga.Name = "BTNnovaKnjiga";
            this.BTNnovaKnjiga.Size = new System.Drawing.Size(167, 48);
            this.BTNnovaKnjiga.TabIndex = 3;
            this.BTNnovaKnjiga.Text = "Nova knjiga";
            this.BTNnovaKnjiga.UseVisualStyleBackColor = true;
            this.BTNnovaKnjiga.Click += new System.EventHandler(this.BTNnovaKnjiga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 264);
            this.Controls.Add(this.BTNnovaKnjiga);
            this.Controls.Add(this.BTNpregled);
            this.Controls.Add(this.BTNnoviKorisnik);
            this.Controls.Add(this.BTNunos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNunos;
        private System.Windows.Forms.Button BTNnoviKorisnik;
        private System.Windows.Forms.Button BTNpregled;
        private System.Windows.Forms.Button BTNnovaKnjiga;
    }
}

