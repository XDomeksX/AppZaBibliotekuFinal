using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Xml;

namespace AppZaBiblioteku
{
    public partial class FormNoviKorisnik : Form
    {
        List<Korisnici> korisnici = new List<Korisnici>();
        string document = "Korisnici.xml";
        int totalID = 0;
        public FormNoviKorisnik()
        {
            InitializeComponent();
        }
        private void BTNunos_Click(object sender, EventArgs e)
        {
            Korisnici korisnik = new Korisnici(TXTime.Text, TXTprezime.Text, TXTemail.Text, TXTbrojTelefona.Text, Convert.ToInt32(TXTid.Text));
            korisnici.Add(korisnik);
            DialogResult dialogResult = MessageBox.Show("Zelite li upisati jos korisnika?", "Upis", MessageBoxButtons.YesNo);

            XmlDocument xmlDoc = new XmlDocument();
            string XMLpath = Directory.GetCurrentDirectory() + @"\Korisnici.xml";
            xmlDoc.Load(XMLpath);

            XmlNodeList IDlist = xmlDoc.GetElementsByTagName("ID_korisnika");
            totalID = IDlist.Count;

            TXTime.Text = "";
            TXTprezime.Text = "";
            TXTemail.Text = "";
            TXTbrojTelefona.Text = "";
            TXTid.Text = Convert.ToString(totalID);

            if (dialogResult == DialogResult.No)
            {
                try
                {
                    var Unos = XDocument.Load(document);
                    foreach (Korisnici forUnos in korisnici)
                    {
                        var XMLunosi = new XElement("Korisnik",
                            new XElement("Ime", forUnos.Ime),
                            new XElement("Prezime", forUnos.Prezime),
                            new XElement("Email", forUnos.Email),
                            new XElement("Broj_telefona", forUnos.BrojTelefona),
                            new XElement("ID_korisnika", forUnos.IdKorisnika));
                        Unos.Root.Add(XMLunosi);
                    }
                    Unos.Save(document);
                }
                catch (Exception)
                {
                    var Unos = new XDocument();
                    Unos.Add(new XElement("Korisnik"));
                    foreach (Korisnici forUnos in korisnici)
                    {
                        var XMLunosi = new XElement("Korisnik",
                            new XElement("Ime", forUnos.Ime),
                            new XElement("Prezime", forUnos.Prezime),
                            new XElement("Email", forUnos.Email),
                            new XElement("Broj_telefona", forUnos.BrojTelefona),
                            new XElement("ID_korisnika", forUnos.IdKorisnika));
                        Unos.Root.Add(XMLunosi);
                    }
                    Unos.Save(document);
                }
                korisnici.Clear();
                this.Close();
            }
        }

        private void FormNoviKorisnik_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            string XMLpath = Directory.GetCurrentDirectory() + @"\Korisnici.xml";
            xmlDoc.Load(XMLpath);

            XmlNodeList IDlist = xmlDoc.GetElementsByTagName("ID_korisnika");
            totalID = IDlist.Count;
            TXTid.Text = Convert.ToString(totalID);
        }
    }
}