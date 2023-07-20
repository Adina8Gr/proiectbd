using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareAnalize:IStocareAnalize
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Analize> GetAnalize()
        {
            var result = new List<Analize>();
            var dsAnalize = SqlDBHelper.ExecuteDataSet("select * from analize_ag", CommandType.Text);

            foreach (DataRow linieBD in dsAnalize.Tables[PRIMUL_TABEL].Rows)
            {

                result.Add(new Analize(linieBD));
            }
            return result;
        }

        public Analize GetAnalize(string id)
        {
            Analize result = null;
            var dsAnalize = SqlDBHelper.ExecuteDataSet("select * from analize_ag where Id_Analiza = :Id_Analiza", CommandType.Text,
                new OracleParameter(":Id_Analiza", OracleDbType.NVarchar2, id, ParameterDirection.Input));

            if (dsAnalize.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsAnalize.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Analize(linieBD);
             
            }
            return result;
        }

        public bool AddAnalize(Analize a)
        {
            return SqlDBHelper.ExecuteNonQuery(
             "insert into analize_ag VALUES (:Id_Analiza, :Denumire, :Tip, :Pret)", CommandType.Text,
              new OracleParameter(":Id_Analiza", OracleDbType.NVarchar2,a.Id_Analiza, ParameterDirection.Input),
             new OracleParameter(":Denumire", OracleDbType.NVarchar2,a.Denumire, ParameterDirection.Input),
             new OracleParameter(":Tip", OracleDbType.NVarchar2, a.Tip, ParameterDirection.Input),
              new OracleParameter(":Pret", OracleDbType.Decimal, a.Pret, ParameterDirection.Input)
              
         );
        }

        public bool UpdateAnalize(Analize a)
        {
            return SqlDBHelper.ExecuteNonQuery(
            "UPDATE analize_ag set Id_Analiza=:Id_Analiza, Denumire=:Denumire, Tip=:Tip, Pret=:Pret", CommandType.Text,
             new OracleParameter(":Id_Analiza", OracleDbType.NVarchar2, a.Id_Analiza, ParameterDirection.Input),
            new OracleParameter(":Denumire", OracleDbType.NVarchar2, a.Denumire, ParameterDirection.Input),
            new OracleParameter(":Tip", OracleDbType.NVarchar2, a.Tip, ParameterDirection.Input),
             new OracleParameter(":Pret", OracleDbType.Decimal, a.Pret, ParameterDirection.Input)

        );
        }
        public bool DeleteAnalize(string id)
        {
            return SqlDBHelper.ExecuteNonQuery("DELETE FROM analize_ag where id_analiza=:Id_Analiza", CommandType.Text, new OracleParameter(":Id_Analiza", OracleDbType.NVarchar2, id, ParameterDirection.Input));
        }
        public List<Analize> GetAnalizeOrdonate(string numeColoana, bool ordineCrescatoare)
        {
            var result = new List<Analize>();

            string query = $"SELECT * FROM analize_ag ORDER BY {numeColoana} {(ordineCrescatoare ? "ASC" : "DESC")}";
            var dsPacienti = SqlDBHelper.ExecuteDataSet(query, CommandType.Text);

            foreach (DataRow linieBD in dsPacienti.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Analize(linieBD));
            }

            return result;
        }
    }
}
