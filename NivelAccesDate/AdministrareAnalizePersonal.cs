using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareAnalizePersonal:IStocareAnalizePersonal
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<AnalizePersonal> GetAnaliPers()
        {
            var result = new List<AnalizePersonal>();
            var dsAnaliPers = SqlDBHelper.ExecuteDataSet("select * from analize_personal_ag", CommandType.Text);

            foreach (DataRow linieBD in dsAnaliPers.Tables[PRIMUL_TABEL].Rows)
            {

                result.Add(new AnalizePersonal(linieBD));
            }
            return result;
        }

        public AnalizePersonal GetAnaliPers(string ids,int id)
        {
            AnalizePersonal result = null;
            var dsAnaliPers = SqlDBHelper.ExecuteDataSet("select * from analize_personal_ag ", CommandType.Text, new OracleParameter(":Id_Analiza", OracleDbType.Int32, ids, ParameterDirection.Input),
                new OracleParameter(":Id_Personal", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsAnaliPers.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsAnaliPers.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new AnalizePersonal(linieBD);
              
            }
            return result;
        }

        public bool AddAnaliPers(AnalizePersonal a)
        {
             return SqlDBHelper.ExecuteNonQuery(
             "insert into analiza_personal_ag VALUES (:Id_Analiza, :Id_Personal)", CommandType.Text,
              new OracleParameter(":Id_Analiza", OracleDbType.NVarchar2, a.Id_Analiza, ParameterDirection.Input),
             new OracleParameter(":Id_Personal", OracleDbType.Int32, a.Id_Personal, ParameterDirection.Input)
            

         );
        }

        public bool UpdateAnaliPers(AnalizePersonal a)
        {
            return SqlDBHelper.ExecuteNonQuery(
             "UPDATE analiza_personal_ag SET Id_Analiza=:Id_Analiza, Id_Personal=:Id_Personal", CommandType.Text,
              new OracleParameter(":Id_Analiza", OracleDbType.NVarchar2, a.Id_Analiza, ParameterDirection.Input),
             new OracleParameter(":Id_Personal", OracleDbType.Int32, a.Id_Personal, ParameterDirection.Input)



         );
        }
    }
}
