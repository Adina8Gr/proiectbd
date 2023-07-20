using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;
using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public class AdministrareBuletinAnalize:IStocareBuletinAnalize
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<BuletinAnalize> GetBuletin()
        {
            var result = new List<BuletinAnalize>();
            var dsBuletin = SqlDBHelper.ExecuteDataSet("select * from buletin_analize_ag", CommandType.Text);

            foreach (DataRow linieBD in dsBuletin.Tables[PRIMUL_TABEL].Rows)
            {
                var buletin = new BuletinAnalize(linieBD);
                buletin.Pacienti = new AdministrarePacienti().GetPacienti(buletin.Id_Pacient);
                buletin.PersonalMedical = new AdministrarePersonalMedical().GetPersonal(buletin.Id_Personal);
                result.Add(buletin);
            }
            return result;
        }

        public BuletinAnalize GetBuletin(int id)
        {
            BuletinAnalize result = null;
            var dsBuletin = SqlDBHelper.ExecuteDataSet("select * from buletin_analize_ag where Id_Buletin = :Id_Buletin", CommandType.Text,
                new OracleParameter(":Id_Buletin", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsBuletin.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsBuletin.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new BuletinAnalize(linieBD);
                //incarca entitatile aditionale
                result.Pacienti = new AdministrarePacienti().GetPacienti(result.Id_Pacient);
                result.PersonalMedical = new AdministrarePersonalMedical().GetPersonal(result.Id_Personal);
            }
            return result;
        }
        public List<BuletinAnalize> GetBuletineByPacientId(int idPacient)
        {
            var result = new List<BuletinAnalize>();
            var query = "SELECT * FROM buletin_analize_ag WHERE Id_Pacient = :IdPacient";
            var parameters = new OracleParameter(":IdPacient", OracleDbType.Int32, idPacient, ParameterDirection.Input);
            var dsRezultat = SqlDBHelper.ExecuteDataSet(query, CommandType.Text, parameters);

            foreach (DataRow linieBD in dsRezultat.Tables[PRIMUL_TABEL].Rows)
            {
                var buletin = new BuletinAnalize(linieBD);
                buletin.Pacienti = new AdministrarePacienti().GetPacienti(buletin.Id_Pacient);
                buletin.PersonalMedical = new AdministrarePersonalMedical().GetPersonal(buletin.Id_Personal);
                result.Add(buletin);
            }

            return result;
        }
        public bool AddBuletin(BuletinAnalize b)
        {
            return SqlDBHelper.ExecuteNonQuery(
             "insert into buletin_analize_ag VALUES (seq_buletin_analize_ag.nextval, :Data_recoltarii,:Data_Rezultate, :Id_Pacient, :Id_Personal)", CommandType.Text,
              new OracleParameter(":Data_recoltarii", OracleDbType.Date, b.Data_recoltarii, ParameterDirection.Input),
             new OracleParameter(":Data_Rezultate", OracleDbType.Date, b.Data_Rezultate, ParameterDirection.Input),
             new OracleParameter(":Id_Pacient", OracleDbType.Int32, b.Id_Pacient, ParameterDirection.Input),
              new OracleParameter(":Id_Personal", OracleDbType.NVarchar2, b.Id_Personal, ParameterDirection.Input)

         );
        }

        public bool UpdateBuletin(BuletinAnalize b)
        {
            return SqlDBHelper.ExecuteNonQuery(
             "UPDATE buletin_analize_ag set  Data_recoltarii=:Data_recoltarii,Data_Rezultate=:Data_Rezultate, Id_Pacient=:Id_Pacient, Id_Personal=:Id_Personal where Id_Buletin=:Id_Buletin", CommandType.Text,
              
             new OracleParameter(":Data_recoltarii", OracleDbType.Date, b.Data_recoltarii, ParameterDirection.Input),
             new OracleParameter(":Data_Rezultate", OracleDbType.Date, b.Data_Rezultate, ParameterDirection.Input),
             new OracleParameter(":Id_Pacient", OracleDbType.Int32, b.Id_Pacient, ParameterDirection.Input),
              new OracleParameter(":Id_Personal", OracleDbType.NVarchar2, b.Id_Personal, ParameterDirection.Input),
               new OracleParameter(":Id_Buletin", OracleDbType.Int32, b.Id_Buletin, ParameterDirection.Input)

         );
        }
        public bool DeleteBuletine(int id)
        {
            return SqlDBHelper.ExecuteNonQuery("DELETE FROM buletine_analize_ag where id_buletin=:Id_Buletin", CommandType.Text, new OracleParameter(":Id_Buletin", OracleDbType.Int32, id, ParameterDirection.Input));
        }
        public int GetNumarBuletine()
        {
            var dsBuletine = SqlDBHelper.ExecuteDataSet("select * from buletin_analize_ag", CommandType.Text);
            return dsBuletine.Tables[0].Rows.Count;
        }
        public Rezultat AfiseazaAnalizeBuletin( int id)
        {
            Rezultat result = null;
            var dsBuletin = SqlDBHelper.ExecuteDataSet("select * from rezultate_ag where Id_Buletin = :Id_Buletin", CommandType.Text,
                new OracleParameter(":Id_Buletin", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsBuletin.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsBuletin.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Rezultat(linieBD);
                //incarca entitatile aditionale

            }
            return result;
        }
        public int GetNrDateBuletin(DateTime d)
        {
        var dsBuletine = SqlDBHelper.ExecuteDataSet("select * from buletin_analize_ag where data_rezultate=to_date(:data_rezultate)", CommandType.Text,
            new OracleParameter(":Data_Rezultate", OracleDbType.Date, d, ParameterDirection.Input));
            return dsBuletine.Tables[0].Rows.Count;
        }
       
        public List<BuletinAnalize> GetBuletineOrdonate(string numeColoana, bool ordineCrescatoare)
        {
            var result = new List<BuletinAnalize>();

            string query = $"SELECT * FROM buletin_analize_ag ORDER BY {numeColoana} {(ordineCrescatoare ? "ASC" : "DESC")}";
            var dsPacienti = SqlDBHelper.ExecuteDataSet(query, CommandType.Text);

            foreach (DataRow linieBD in dsPacienti.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new BuletinAnalize(linieBD));
            }

            return result;
        }
        
    }
}
