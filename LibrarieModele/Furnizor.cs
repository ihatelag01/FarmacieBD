using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
   public class Furnizor
    {
        public string denumire { get; set; }

        public string adresa { get; set; }

        public string tara { get; set; }

        public Furnizor(string denumire, string adresa, string tara)
        {
            this.denumire = denumire;
            this.adresa = adresa;
            this.tara = tara;
        }

        public Furnizor(DataRow linieDB)
        {
            this.denumire = linieDB["Denumire"].ToString();
            this.adresa = linieDB["adresa"].ToString();
            this.tara = linieDB["tara_origine"].ToString();
        }
    }
}
