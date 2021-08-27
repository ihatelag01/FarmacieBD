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
            return SqlDBHelper.ExecuteNonQuery("insert into Medicamente_AV values(:Id,:Denumire,:Pret,:DataExpirare,:Depozitare)",CommandType.Text,
                new OracleParameter(":Id",OracleDbType.Int32,m.id,ParameterDirection.Input),
                new OracleParameter(":Denumire", OracleDbType.NVarchar2, m.denumire, ParameterDirection.Input),
                new OracleParameter(":Pret",OracleDbType.Decimal,m.pret,ParameterDirection.Input),
                new OracleParameter(":DataExpirare",OracleDbType.Date,m.dataExpirare,ParameterDirection.Input),
                new OracleParameter(":Depozitare",OracleDbType.Int32,m.tipDepozitare,ParameterDirection.Input));
        }

        public bool DeleteMedicament(int id)
        {
            return SqlDBHelper.ExecuteNonQuery("delete from Medicamente_AV where Id=:Id", CommandType.Text,
                new OracleParameter(":Id", OracleDbType.Int32, id, ParameterDirection.Input));
        }
    }
}
