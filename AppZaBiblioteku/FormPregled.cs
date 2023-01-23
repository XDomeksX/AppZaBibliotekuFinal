using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace AppZaBiblioteku
{
    public partial class FormPregled : Form
    {
        string document = @"C:\Programs\VisualStudio\Csharp\AppZaBiblioteku\AppZaBiblioteku\bin\Debug\Unosi.xml";
        public FormPregled()
        {
            InitializeComponent();
        }

        private void BTNpregledaj_Click(object sender, EventArgs e)
        {
            /*Pregled pregled = new Pregled(TXTidKnjige.Text, TXTidKorisnika.Text);

            var xmlFile = XDocument.Load(document);

            var result = from s in xmlFile
                         where s.ID_knjige.Contains(TXTidKnjige.Text)
                         select s;

            foreach (var s in result)
            {
                Console.WriteLine(s.ID_kmjige);
            }*/
            /*XElement root = XElement.Load(document);
            IEnumerable<XElement> address =
                from el in root.Elements("Unos")
                where el.ID_knjige.Contains("")
                select el;
            foreach (XElement el in address)
                Console.WriteLine(el);*/
        }
    }
}
