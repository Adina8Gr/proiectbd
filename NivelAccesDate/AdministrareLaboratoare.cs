using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareLaboratoare:IStocareLaboratoare
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<Laboratoare> GetLaboratoare()
        {
            var result = new List<Laboratoare>();
            var dsLaboratoare = SqlDBHelper.ExecuteDataSet("select * from laboratoare_ag", CommandType.Text);

            foreach (DataRow linieBD in dsLaboratoare.Tables[PRIMUL_TABEL].Rows)
            {

                result.Add(new Laboratoare(linieBD));
            }
            return result;
        }

        public Laboratoare GetLaboratoare(int id)
        {
            Laboratoare result = null;
            var dsLaboratoare = SqlDBHelper.ExecuteDataSet("select * from laboratoare_ag where Id_Laborator = :Id_Laborator", CommandType.Text,
                new OracleParameter(":Id_Laborator", OracleDbType.Int32, id, ParameterDirection.Input));

            if (dsLaboratoare.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsLaboratoare.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Laboratoare(linieBD);
                //incarca entitatile aditionale
               
            }
            return result;
        }

        public bool AddLaboratoare(Laboratoare l)
        {
            return  SqlDBHelper.ExecuteNonQuery("INSERT INTO laboratoare_ag VALUES(seq_laboratoare_ag.newxval, :Nume_Laborator, :Adresa, :Telefon)",CommandType.Text, new OracleParameter(":Nume_Laborator",OracleDbType.NVarchar2,l.Nume_Laborator,ParameterDirection.Input),
                new OracleParameter(":Adresa", OracleDbType.NVarchar2, l.Adresa, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.Int64, l.Telefon, ParameterDirection.Input));
        }

        public bool UpdateLaboratoare(Laboratoare l)
        {
            return SqlDBHelper.ExecuteNonQuery("UPDATE laboratoare_ag set Nume_Laborator=:Nume_Laborator, Adresa=:Adresa, Telefon=:Telefon where Id_Laborator=:Id_Laborator", CommandType.Text, new OracleParameter(":Nume_Laborator", OracleDbType.NVarchar2, l.Nume_Laborator, ParameterDirection.Input),
               new OracleParameter(":Adresa", OracleDbType.NVarchar2, l.Adresa, ParameterDirection.Input),
               new OracleParameter(":Telefon", OracleDbType.Int64, l.Telefon, ParameterDirection.Input),
               new OracleParameter(":Id_Laborator", OracleDbType.Int32, l.Id_Laborator, ParameterDirection.Input));
        }
        public bool DeleteLaboratoare(int id)
        {
            return SqlDBHelper.ExecuteNonQuery("DELETE FROM laboratoare_ag where id_laborator=:Id_Laborator", CommandType.Text, new OracleParameter(":Id_Laborator", OracleDbType.Int32, id, ParameterDirection.Input));
        }
        public List<Laboratoare> GetLaboratoareOrdonate(string numeColoana, bool ordineCrescatoare)
        {
            var result = new List<Laboratoare>();

            string query = $"SELECT * FROM laboratoare_ag ORDER BY {numeColoana} {(ordineCrescatoare ? "ASC" : "DESC")}";
            var dsPacienti = SqlDBHelper.ExecuteDataSet(query, CommandType.Text);

            foreach (DataRow linieBD in dsPacienti.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Laboratoare(linieBD));
            }

            return result;
        }
    }
}
