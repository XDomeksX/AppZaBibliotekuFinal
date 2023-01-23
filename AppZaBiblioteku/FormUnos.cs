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

namespace AppZaBiblioteku
{
    public partial class FormUnos : Form
    {
        List<Unos> unosi = new List<Unos>();
        string document = "Unosi.xml";
        public FormUnos()
        {
            InitializeComponent();
        }

        private void BTNunesi_Click(object sender, EventArgs e)
        {
            Unos unos = new Unos(TXTidKnjige.Text, TXTidKorisnika.Text, DTPposuđivanja.Value);
            unosi.Add(unos);
            DialogResult dialogResult = MessageBox.Show("Zelite li upisati jos korisnika?", "Upis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                try
                {
                    var Unos = XDocument.Load(document);
                    foreach (Unos forUnos in unosi)
                    {
                        var XMLunosi = new XElement("Unos",
                            new XElement("ID_knjige", forUnos.IdKnjige),
                            new XElement("ID_korisnika", forUnos.IdKorisnika),
                            new XElement("Datum_posudenja", forUnos.Datum),
                            new XElement("Datum_vraćanja", forUnos.Datum.AddDays(14)));
                        Unos.Root.Add(XMLunosi);
                    }
                    Unos.Save(document);
                }
                catch (Exception)
                {
                    var Unos = new XDocument();
                    Unos.Add(new XElement("Unos"));
                    foreach (Unos forUnos in unosi)
                    {
                        var XMLunosi = new XElement("Unos",
                            new XElement("ID_knjige", forUnos.IdKnjige),
                            new XElement("ID_korisnika", forUnos.IdKorisnika),
                            new XElement("Datum_posudenja", forUnos.Datum),
                            new XElement("Datum_vraćanja", forUnos.Datum.AddDays(14)));
                        Unos.Root.Add(XMLunosi);
                    }
                    Unos.Save(document);
                }
                unosi.Clear();
                this.Close();
            }
            TXTidKnjige.Text = "";
            TXTidKorisnika.Text = "";
        }
    }
}