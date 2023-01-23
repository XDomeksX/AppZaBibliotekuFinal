using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppZaBiblioteku
{
    internal class Korisnici
    {
        string ime, prezime, email, brojTelefona;
        int idKorisnika;

        public Korisnici(string ime, string prezime, string email, string brojTelefona, int idKorisnika)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.BrojTelefona = brojTelefona;
            this.IdKorisnika = idKorisnika;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public int IdKorisnika { get => idKorisnika; set => idKorisnika = value; }

        public override string ToString()
        {
            return "Ime: " + ime + "\r\nPrezime: " + Prezime + "\r\nEmail: " + Email + "\r\nBrojTelefona: " + BrojTelefona + "\r\nID: " + IdKorisnika;
        }
    }
}
