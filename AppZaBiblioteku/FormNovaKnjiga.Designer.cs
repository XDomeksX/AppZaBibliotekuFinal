namespace AppZaBiblioteku
{
    partial class FormNovaKnjiga
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
            this.TXTgodinaIzdanja = new System.Windows.Forms.TextBox();
            this.LBLgodinaIzdanja = new System.Windows.Forms.Label();
            this.TXTnazivKnjige = new System.Windows.Forms.TextBox();
            this.LBLnazivKnjige = new System.Windows.Forms.Label();
            this.LBLautor = new System.Windows.Forms.Label();
            this.TXTautor = new System.Windows.Forms.TextBox();
            this.TXTid = new System.Windows.Forms.TextBox();
            this.LBLid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNunos
            // 
            this.BTNunos.Location = new System.Drawing.Point(277, 12);
            this.BTNunos.Name = "BTNunos";
            this.BTNunos.Size = new System.Drawing.Size(97, 91);
            this.BTNunos.TabIndex = 13;
            this.BTNunos.Text = "Unos";
            this.BTNunos.UseVisualStyleBackColor = true;
            this.BTNunos.Click += new System.EventHandler(this.BTNunos_Click);
            // 
            // TXTgodinaIzdanja
            // 
            this.TXTgodinaIzdanja.Location = new System.Drawing.Point(97, 61);
            this.TXTgodinaIzdanja.Name = "TXTgodinaIzdanja";
            this.TXTgodinaIzdanja.Size = new System.Drawing.Size(165, 20);
            this.TXTgodinaIzdanja.TabIndex = 12;
            // 
            // LBLgodinaIzdanja
            // 
            this.LBLgodinaIzdanja.AutoSize = true;
            this.LBLgodinaIzdanja.Location = new System.Drawing.Point(11, 64);
            this.LBLgodinaIzdanja.Name = "LBLgodinaIzdanja";
            this.LBLgodinaIzdanja.Size = new System.Drawing.Size(80, 13);
            this.LBLgodinaIzdanja.TabIndex = 11;
            this.LBLgodinaIzdanja.Text = "Godina izdanja:";
            // 
            // TXTnazivKnjige
            // 
            this.TXTnazivKnjige.Location = new System.Drawing.Point(85, 35);
            this.TXTnazivKnjige.Name = "TXTnazivKnjige";
            this.TXTnazivKnjige.Size = new System.Drawing.Size(177, 20);
            this.TXTnazivKnjige.TabIndex = 10;
            // 
            // LBLnazivKnjige
            // 
            this.LBLnazivKnjige.AutoSize = true;
            this.LBLnazivKnjige.Location = new System.Drawing.Point(11, 38);
            this.LBLnazivKnjige.Name = "LBLnazivKnjige";
            this.LBLnazivKnjige.Size = new System.Drawing.Size(68, 13);
            this.LBLnazivKnjige.TabIndex = 9;
            this.LBLnazivKnjige.Text = "Naziv knjige:";
            // 
            // LBLautor
            // 
            this.LBLautor.AutoSize = true;
            this.LBLautor.Location = new System.Drawing.Point(11, 12);
            this.LBLautor.Name = "LBLautor";
            this.LBLautor.Size = new System.Drawing.Size(35, 13);
            this.LBLautor.TabIndex = 8;
            this.LBLautor.Text = "Autor:";
            // 
            // TXTautor
            // 
            this.TXTautor.Location = new System.Drawing.Point(52, 9);
            this.TXTautor.Name = "TXTautor";
            this.TXTautor.Size = new System.Drawing.Size(210, 20);
            this.TXTautor.TabIndex = 7;
            // 
            // TXTid
            // 
            this.TXTid.Location = new System.Drawing.Point(38, 87);
            this.TXTid.Name = "TXTid";
            this.TXTid.Size = new System.Drawing.Size(224, 20);
            this.TXTid.TabIndex = 15;
            // 
            // LBLid
            // 
            this.LBLid.AutoSize = true;
            this.LBLid.Location = new System.Drawing.Point(11, 90);
            this.LBLid.Name = "LBLid";
            this.LBLid.Size = new System.Drawing.Size(21, 13);
            this.LBLid.TabIndex = 14;
            this.LBLid.Text = "ID:";
            // 
            // FormNovaKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 118);
            this.Controls.Add(this.TXTid);
            this.Controls.Add(this.LBLid);
            this.Controls.Add(this.BTNunos);
            this.Controls.Add(this.TXTgodinaIzdanja);
            this.Controls.Add(this.LBLgodinaIzdanja);
            this.Controls.Add(this.TXTnazivKnjige);
            this.Controls.Add(this.LBLnazivKnjige);
            this.Controls.Add(this.LBLautor);
            this.Controls.Add(this.TXTautor);
            this.Name = "FormNovaKnjiga";
            this.Text = "FormNovaKnjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNunos;
        private System.Windows.Forms.TextBox TXTgodinaIzdanja;
        private System.Windows.Forms.Label LBLgodinaIzdanja;
        private System.Windows.Forms.TextBox TXTnazivKnjige;
        private System.Windows.Forms.Label LBLnazivKnjige;
        private System.Windows.Forms.Label LBLautor;
        private System.Windows.Forms.TextBox TXTautor;
        private System.Windows.Forms.TextBox TXTid;
        private System.Windows.Forms.Label LBLid;
    }
}