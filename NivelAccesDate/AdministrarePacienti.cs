using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrarePacienti:IStocarePacienti
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Pacienti> GetPacienti()
        {
            var result = new List<Pacienti>();
            var dsPacienti = SqlDBHelper.ExecuteDataSet("select * from pacienti_ag", CommandType.Text);

            foreach (DataRow linieBD in dsPacienti.Tables[PRIMUL_TABEL].Rows)
            {
                
                result.Add(new Pacienti(linieBD));
            }
            return result;
        }
        
        public Pacienti GetPacienti(int id)
        {
            Pacienti result = null;
            var dsPacienti = SqlDBHelper.ExecuteDataSet("select * from pacienti_ag where Id_Pacient = :Id_Pacient", CommandType.Text,
                new OracleParameter(":Id_Pacient", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsPacienti.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsPacienti.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Pacienti(linieBD);
              
                
            }
            return result;
        }

        public bool AddPacienti(Pacienti p)
        {
            return SqlDBHelper.ExecuteNonQuery(
               "insert into pacienti_ag VALUES (seq_pacienti_ag.nextval, :Nume, :Prenume, :CNP, :Data_nasterii,:Sex,:Telefon,:Adresa)", CommandType.Text,
               new OracleParameter(":Nume", OracleDbType.NVarchar2, p.Nume, ParameterDirection.Input),
               new OracleParameter(":Prenume", OracleDbType.NVarchar2, p.Prenume, ParameterDirection.Input),
               new OracleParameter(":CNP", OracleDbType.Int64, p.CNP, ParameterDirection.Input),
               new OracleParameter(":Data_nasterii", OracleDbType.Date, p.Data_nasterii, ParameterDirection.Input),
               new OracleParameter(":Sex", OracleDbType.NChar,p.Sex, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.Int64, p.Telefon, ParameterDirection.Input),
                 new OracleParameter(":Adresa", OracleDbType.NVarchar2, p.Adresa, ParameterDirection.Input)
           );
        }

        public bool UpdatePacienti(Pacienti p)
        {
            return SqlDBHelper.ExecuteNonQuery(
                 "UPDATE pacienti_ag set  nume =:Nume, prenume =:Prenume, cnp=:CNP, data_nasterii=:Data_nasterii, sex=:Sex, telefon=:Telefon, adresa=:Adresa where id_pacient=:Id_Pacient", CommandType.Text,
                   new OracleParameter(":Nume", OracleDbType.NVarchar2, p.Nume, ParameterDirection.Input),
                   new OracleParameter(":Prenume", OracleDbType.NVarchar2, p.Prenume, ParameterDirection.Input),
               new OracleParameter(":CNP", OracleDbType.Int64, p.CNP, ParameterDirection.Input),
               new OracleParameter(":Data_nasterii", OracleDbType.Date, p.Data_nasterii, ParameterDirection.Input),
                new OracleParameter(":Sex", OracleDbType.NChar, p.Sex, ParameterDirection.Input),
               new OracleParameter(":Telefon", OracleDbType.Int64, p.Telefon, ParameterDirection.Input),
                 new OracleParameter(":Adresa", OracleDbType.NVarchar2, p.Adresa, ParameterDirection.Input),
                   new OracleParameter(":Id_Pacient", OracleDbType.Int32, p.Id_Pacient, ParameterDirection.Input)


             );
        }
        
        public int GetNumarPacienti()
        {
            var dsPacienti = SqlDBHelper.ExecuteDataSet("select * from pacienti_ag", CommandType.Text);
            return dsPacienti.Tables[0].Rows.Count;
        }
        public List<Pacienti> GetPacientiOrdonati(string numeColoana, bool ordineCrescatoare)
        {
            var result = new List<Pacienti>();

            string query = $"SELECT * FROM pacienti_ag ORDER BY {numeColoana} {(ordineCrescatoare ? "ASC" : "DESC")}";
            var dsPacienti = SqlDBHelper.ExecuteDataSet(query, CommandType.Text);

            foreach (DataRow linieBD in dsPacienti.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Pacienti(linieBD));
            }

            return result;
        }
      


        public bool DeletePacienti(int id)
        {
            return SqlDBHelper.ExecuteNonQuery("DELETE FROM pacienti_ag where id_pacient=:Id_Pacient", CommandType.Text, new OracleParameter(":Id_Pacient", OracleDbType.Int32, id, ParameterDirection.Input));
        }
        /*public bool DeleteSoftPacienti(int id)
        {
            SqlDBHelper.ExecuteNonQuery("ALTER TABLE Pacienti_ag ADD deleted_at ", CommandType.Text, new OracleParameter(":Id_Pacient", OracleDbType.Int32, id, ParameterDirection.Input));
            return SqlDBHelper.ExecuteNonQuery("UPDATE Pacienti_ag set deleted_at=null where id_pacient=:Id_Pacient", CommandType.Text, new OracleParameter(":Id_Pacient", OracleDbType.Int32, id, ParameterDirection.Input));
        }*/
        public bool DeleteSoftPacienti(int id)
        {
            string queryAddColumn = "ALTER TABLE Pacienti_ag ADD deleted_at DATE NULL";
            string queryUpdateRecord = "UPDATE Pacienti_ag SET deleted_at = NULL WHERE id_pacient = :Id_Pacient";

            SqlDBHelper.ExecuteNonQuery(queryAddColumn, CommandType.Text);
            return SqlDBHelper.ExecuteNonQuery(queryUpdateRecord, CommandType.Text, new OracleParameter(":Id_Pacient", OracleDbType.Int32, id, ParameterDirection.Input));
        }


    }
}
