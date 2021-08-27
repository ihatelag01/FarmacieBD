using System;
using System.Data;

namespace LibrarieModele
{
    public class Medicament
    {
        public int id { get; set; }
        public string denumire { get; set; }
        public double pret { get; set; }
        public DateTime dataExpirare { get; set; }
        public int tipDepozitare { get; set; }

        public Medicament(int id, string denumire, double pret, DateTime dataExpirare, int tipDepozitare)
        {
            this.id = id;
            this.denumire = denumire;
            this.pret = pret;
            this.dataExpirare = dataExpirare;
            this.tipDepozitare = tipDepozitare;
        }

        public Medicament(DataRow linieDB)
        {
            id = Convert.ToInt32(linieDB["Id"].ToString());
            denumire = linieDB["Denumire"].ToString();
            pret = Convert.ToDouble(linieDB["Pret"].ToString());
            dataExpirare = Convert.ToDateTime(linieDB["DataExpirare"].ToString());
            tipDepozitare = Convert.ToInt32(linieDB["Depozitare"].ToString());
        }
    }
}
