using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppZaBiblioteku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNnoviKorisnik_Click_1(object sender, EventArgs e)
        {
            FormNoviKorisnik noviKorisnik = new FormNoviKorisnik();
            noviKorisnik.Show();
        }
        private void BTNnovaKnjiga_Click(object sender, EventArgs e)
        {
            FormNovaKnjiga novaKnjiga = new FormNovaKnjiga();
            novaKnjiga.Show();
        }
        private void BTNunos_Click(object sender, EventArgs e)
        {
            FormUnos unos = new FormUnos();
            unos.Show();
        }

        private void BTNpregled_Click(object sender, EventArgs e)
        {
            FormPregled pregled = new FormPregled();
            pregled.Show();
        }
    }
}
