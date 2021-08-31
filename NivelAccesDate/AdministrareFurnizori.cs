using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
  public  class AdministrareFurnizori:IStocareFurnizori
    {
        private const int PRIMUL_TABEL = 0;

        private const int PRIMA_LINIE = 0;

       public List<Furnizor> GetFurnizori()
        {
            var result = new List<Furnizor>();
            var dsFurnizori = SqlDBHelper.ExecuteDataSet("select * from Furnizori_AV", CommandType.Text);
            foreach (DataRow linieDB in dsFurnizori.Tables[0].Rows)
            {
                result.Add(new Furnizor(linieDB));
            }

            return result;
        }
    }
}
