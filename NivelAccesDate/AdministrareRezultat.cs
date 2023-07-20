using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareRezultat:IStocareRezultat
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Rezultat> GetRezultat()
        {
            var result = new List<Rezultat>();
            var dsRezultat = SqlDBHelper.ExecuteDataSet("select * from rezultate_ag", CommandType.Text);

            foreach (DataRow linieBD in dsRezultat.Tables[PRIMUL_TABEL].Rows)
            {
                var rezultat = new Rezultat(linieBD);
                rezultat.Analize = new AdministrareAnalize().GetAnalize(rezultat.Id_Analiza);
                rezultat.BuletinAnalize = new AdministrareBuletinAnalize().GetBuletin(rezultat.Id_Buletin);
                result.Add(rezultat);
            }
            return result;
        }

        public Rezultat GetRezultat(int id)
        {
            Rezultat result = null;
            var dsRezultat = SqlDBHelper.ExecuteDataSet("select * from rezultate_ag where Id_Rezultat=:Id_Rezultat", CommandType.Text,
                new OracleParameter(":Id_Rezultat", OracleDbType.Int32, id, ParameterDirection.Input)
                 );

            if (dsRezultat.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsRezultat.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Rezultat(linieBD);
                result.BuletinAnalize = new AdministrareBuletinAnalize().GetBuletin(result.Id_Buletin);
                result.Analize = new AdministrareAnalize().GetAnalize(result.Id_Analiza);
               
            }
            return result;
        }
       
        public List<Rezultat> GetRezultateByBuletinId(int idBuletin)
        {
            var result = new List<Rezultat>();
            var query = "SELECT * FROM rezultate_ag WHERE Id_Buletin = :IdBuletin";
            var parameters = new OracleParameter(":IdBuletin", OracleDbType.Int32, idBuletin, ParameterDirection.Input);
            var dsRezultat = SqlDBHelper.ExecuteDataSet(query, CommandType.Text, parameters);

            foreach (DataRow linieBD in dsRezultat.Tables[PRIMUL_TABEL].Rows)
            {
                var rezultat = new Rezultat(linieBD);
                rezultat.Analize = new AdministrareAnalize().GetAnalize(rezultat.Id_Analiza);
                rezultat.BuletinAnalize = new AdministrareBuletinAnalize().GetBuletin(rezultat.Id_Buletin);
                result.Add(rezultat);
            }

            return result;
        }
        public int GetNumarRezultate()
        {
            var dsRezultate = SqlDBHelper.ExecuteDataSet("select * from rezultate_ag", CommandType.Text);
            return dsRezultate.Tables[0].Rows.Count;
        }
        public bool AddRezultat(Rezultat r)
        {
            return SqlDBHelper.ExecuteNonQuery(
               "insert into rezultate_ag VALUES (:Id_Buletin, :Id_Analiza, :Rezultat_Analiza, :Comentarii,seq_rezultate_ag.nextval)", CommandType.Text,
               new OracleParameter(":Id_Buletin", OracleDbType.Int32, r.Id_Buletin, ParameterDirection.Input),
               new OracleParameter(":Id_Analiza", OracleDbType.NVarchar2, r.Id_Analiza, ParameterDirection.Input),
               new OracleParameter(":Rezultat_Analiza", OracleDbType.Int32, r.Rezultat_Analiza, ParameterDirection.Input),
               new OracleParameter(":Comentarii", OracleDbType.NVarchar2, r.Comentarii, ParameterDirection.Input)
           );
        }

        public bool UpdateRezultat(Rezultat r)
        {

            return SqlDBHelper.ExecuteNonQuery(
               "UPDATE rezultate_ag set Id_Buletin=:Id_Buletin, Id_Analiza=:Id_Analiza, Rezultat_Analiza=:Rezultat_Analiza, Comentarii=:Comentarii where Id_Rezultat=:Id_Rezultat", CommandType.Text,
              
               new OracleParameter(":Id_Buletin", OracleDbType.Int32, r.Id_Buletin, ParameterDirection.Input),
               new OracleParameter(":Id_Analiza", OracleDbType.NVarchar2, r.Id_Analiza, ParameterDirection.Input),
               new OracleParameter(":Rezultat_Analiza", OracleDbType.Int32, r.Rezultat_Analiza, ParameterDirection.Input),
               new OracleParameter(":Comentarii", OracleDbType.NVarchar2, r.Comentarii, ParameterDirection.Input),
                new OracleParameter(":Id_Rezultat", OracleDbType.Int32, r.Id_Rezultat, ParameterDirection.Input)
           );
        }
        public bool DeleteRezultate(int id)
        {
            return SqlDBHelper.ExecuteNonQuery("DELETE FROM rezultate_ag where id_rezultat=:Id_Rezultat", CommandType.Text, new OracleParameter(":Id_Rezultat", OracleDbType.Int32, id, ParameterDirection.Input));
        }

        public List<Rezultat> GetRezultatOrdonat(string numeColoana, bool ordineCrescatoare)
        {
            var result = new List<Rezultat>();

            string query = $"SELECT * FROM rezultate_ag ORDER BY {numeColoana} {(ordineCrescatoare ? "ASC" : "DESC")}";
            var dsPacienti = SqlDBHelper.ExecuteDataSet(query, CommandType.Text);

            foreach (DataRow linieBD in dsPacienti.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Rezultat(linieBD));
            }

            return result;
        }
    }
}
