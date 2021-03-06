using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
   public class AdministrareMedicamente:IStocareMedicamente
    {
        private const int PRIMUL_TABEL = 0;

        private const int PRIMA_LINIE = 0;

        public List<Medicament> GetMedicamente()
        {
            var result = new List<Medicament>();

            var dsMedicamente = SqlDBHelper.ExecuteDataSet("select * from Medicamente_AV",CommandType.Text);

            foreach (DataRow linieDB in dsMedicamente.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Medicament(linieDB));
            }

            return result;
        }

        public bool AddMedicament(Medicament m)
        {
            return SqlDBHelper.ExecuteNonQuery("insert into Medicamente_AV values(:Id,:Denumire,:Pret,:DataExpirare,:Furnizor)",
                CommandType.Text,
                new OracleParameter(":Id", OracleDbType.Int32, m.ID, ParameterDirection.Input),
                new OracleParameter(":Denumire", OracleDbType.NVarchar2, m.Denumire, ParameterDirection.Input),
                new OracleParameter(":Pret", OracleDbType.Decimal, m.Pret, ParameterDirection.Input),
                new OracleParameter(":DataExpirare", OracleDbType.Date, m.DataExpirare, ParameterDirection.Input),
                new OracleParameter(":Furnizor",OracleDbType.NVarchar2,m.Furnizor,ParameterDirection.Input));
        }

        public bool DeleteMedicament(int id)
        {
            return SqlDBHelper.ExecuteNonQuery("delete from Medicamente_AV where Id=:Id", CommandType.Text,
                new OracleParameter(":Id", OracleDbType.Int32, id, ParameterDirection.Input));
        }
        
        public bool UpdateMedicamente(Medicament m)
        {
            return SqlDBHelper.ExecuteNonQuery("update Medicamente_AV set Id=:Id, Denumire=:Denumire, Pret=:Pret, DataExpirare=:DataExpirare, Furnizor=:Furnizor where ID=:ID",CommandType.Text,
                new  OracleParameter(":Id",OracleDbType.NVarchar2,m.ID,ParameterDirection.Input),
                new OracleParameter(":Denumire",OracleDbType.NVarchar2,m.Denumire,ParameterDirection.Input),
                new OracleParameter(":Pret",OracleDbType.Decimal,m.Pret,ParameterDirection.Input),
                new OracleParameter(":DataExpirare",OracleDbType.Date,m.DataExpirare,ParameterDirection.Input),
                new OracleParameter(":Furnizor",OracleDbType.NVarchar2,m.Furnizor,ParameterDirection.Input));
        }
    }
}
