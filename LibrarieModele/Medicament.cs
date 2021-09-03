using System;
using System.Data;

namespace LibrarieModele
{
    public class Medicament
    {
        public int ID { get; set; }

        public string Denumire { get; set; }

        public double Pret { get; set; }

        public DateTime DataExpirare { get; set; }

        public string Furnizor { get; set; }

        public Medicament(int id, string denumire, double pret, DateTime dataExpirare, string furnizor)
        {
            this.ID = id;
            this.Denumire = denumire;
            this.Pret = pret;
            this.DataExpirare = dataExpirare;
            this.Furnizor = furnizor;
        }

        public Medicament(DataRow linieDB)
        {
            ID = Convert.ToInt32(linieDB["Id"].ToString());
            Denumire = linieDB["Denumire"].ToString();
            Pret = Convert.ToDouble(linieDB["Pret"].ToString());
            DataExpirare = Convert.ToDateTime(linieDB["DataExpirare"].ToString());
            Furnizor = linieDB["Furnizor"].ToString();
        }
    }
}
