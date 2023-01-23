namespace AppZaBiblioteku
{
    partial class FormNoviKorisnik
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
            this.TXTime = new System.Windows.Forms.TextBox();
            this.LBLime = new System.Windows.Forms.Label();
            this.LBLprezime = new System.Windows.Forms.Label();
            this.TXTprezime = new System.Windows.Forms.TextBox();
            this.TXTid = new System.Windows.Forms.TextBox();
            this.LBLid = new System.Windows.Forms.Label();
            this.BTNunos = new System.Windows.Forms.Button();
            this.TXTbrojTelefona = new System.Windows.Forms.TextBox();
            this.LBLbrojTelefona = new System.Windows.Forms.Label();
            this.LBLemail = new System.Windows.Forms.Label();
            this.TXTemail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTime
            // 
            this.TXTime.Location = new System.Drawing.Point(45, 12);
            this.TXTime.Name = "TXTime";
            this.TXTime.Size = new System.Drawing.Size(190, 20);
            this.TXTime.TabIndex = 0;
            // 
            // LBLime
            // 
            this.LBLime.AutoSize = true;
            this.LBLime.Location = new System.Drawing.Point(12, 15);
            this.LBLime.Name = "LBLime";
            this.LBLime.Size = new System.Drawing.Size(27, 13);
            this.LBLime.TabIndex = 1;
            this.LBLime.Text = "Ime:";
            // 
            // LBLprezime
            // 
            this.LBLprezime.AutoSize = true;
            this.LBLprezime.Location = new System.Drawing.Point(12, 41);
            this.LBLprezime.Name = "LBLprezime";
            this.LBLprezime.Size = new System.Drawing.Size(47, 13);
            this.LBLprezime.TabIndex = 2;
            this.LBLprezime.Text = "Prezime:";
            // 
            // TXTprezime
            // 
            this.TXTprezime.Location = new System.Drawing.Point(64, 38);
            this.TXTprezime.Name = "TXTprezime";
            this.TXTprezime.Size = new System.Drawing.Size(171, 20);
            this.TXTprezime.TabIndex = 3;
            // 
            // TXTid
            // 
            this.TXTid.Enabled = false;
            this.TXTid.Location = new System.Drawing.Point(39, 116);
            this.TXTid.Name = "TXTid";
            this.TXTid.Size = new System.Drawing.Size(196, 20);
            this.TXTid.TabIndex = 5;
            // 
            // LBLid
            // 
            this.LBLid.AutoSize = true;
            this.LBLid.Location = new System.Drawing.Point(12, 119);
            this.LBLid.Name = "LBLid";
            this.LBLid.Size = new System.Drawing.Size(21, 13);
            this.LBLid.TabIndex = 4;
            this.LBLid.Text = "ID:";
            // 
            // BTNunos
            // 
            this.BTNunos.Location = new System.Drawing.Point(251, 15);
            this.BTNunos.Name = "BTNunos";
            this.BTNunos.Size = new System.Drawing.Size(80, 117);
            this.BTNunos.TabIndex = 6;
            this.BTNunos.Text = "Unos";
            this.BTNunos.UseVisualStyleBackColor = true;
            this.BTNunos.Click += new System.EventHandler(this.BTNunos_Click);
            // 
            // TXTbrojTelefona
            // 
            this.TXTbrojTelefona.Location = new System.Drawing.Point(46, 90);
            this.TXTbrojTelefona.Name = "TXTbrojTelefona";
            this.TXTbrojTelefona.Size = new System.Drawing.Size(189, 20);
            this.TXTbrojTelefona.TabIndex = 10;
            // 
            // LBLbrojTelefona
            // 
            this.LBLbrojTelefona.AutoSize = true;
            this.LBLbrojTelefona.Location = new System.Drawing.Point(12, 93);
            this.LBLbrojTelefona.Name = "LBLbrojTelefona";
            this.LBLbrojTelefona.Size = new System.Drawing.Size(28, 13);
            this.LBLbrojTelefona.TabIndex = 9;
            this.LBLbrojTelefona.Text = "Tel.:";
            // 
            // LBLemail
            // 
            this.LBLemail.AutoSize = true;
            this.LBLemail.Location = new System.Drawing.Point(12, 67);
            this.LBLemail.Name = "LBLemail";
            this.LBLemail.Size = new System.Drawing.Size(35, 13);
            this.LBLemail.TabIndex = 8;
            this.LBLemail.Text = "Email:";
            // 
            // TXTemail
            // 
            this.TXTemail.Location = new System.Drawing.Point(53, 64);
            this.TXTemail.Name = "TXTemail";
            this.TXTemail.Size = new System.Drawing.Size(182, 20);
            this.TXTemail.TabIndex = 7;
            // 
            // FormNoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 146);
            this.Controls.Add(this.TXTbrojTelefona);
            this.Controls.Add(this.LBLbrojTelefona);
            this.Controls.Add(this.LBLemail);
            this.Controls.Add(this.TXTemail);
            this.Controls.Add(this.BTNunos);
            this.Controls.Add(this.TXTid);
            this.Controls.Add(this.LBLid);
            this.Controls.Add(this.TXTprezime);
            this.Controls.Add(this.LBLprezime);
            this.Controls.Add(this.LBLime);
            this.Controls.Add(this.TXTime);
            this.Name = "FormNoviKorisnik";
            this.Text = "FormNoviKorisnik";
            this.Load += new System.EventHandler(this.FormNoviKorisnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTime;
        private System.Windows.Forms.Label LBLime;
        private System.Windows.Forms.Label LBLprezime;
        private System.Windows.Forms.TextBox TXTprezime;
        private System.Windows.Forms.TextBox TXTid;
        private System.Windows.Forms.Label LBLid;
        private System.Windows.Forms.Button BTNunos;
        private System.Windows.Forms.TextBox TXTbrojTelefona;
        private System.Windows.Forms.Label LBLbrojTelefona;
        private System.Windows.Forms.Label LBLemail;
        private System.Windows.Forms.TextBox TXTemail;
    }
}