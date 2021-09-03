using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareFurnizori : IStocareFurnizori
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

        public bool AddFurnizor(Furnizor f)
        {
            return SqlDBHelper.ExecuteNonQuery("insert into Furnizori_AV values(:Denumire,:Adresa,:tara_origine)",
                CommandType.Text,
                new OracleParameter(":Denumire", OracleDbType.NVarchar2, f.denumire, ParameterDirection.Input),
                new OracleParameter(":Adresa", OracleDbType.NVarchar2, f.adresa, ParameterDirection.Input),
                new OracleParameter(":tara_origine", OracleDbType.NVarchar2, f.tara, ParameterDirection.Input));
        }
    }
}
