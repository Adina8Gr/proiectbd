using System.Collections.Generic;
using System.Data;
using LibrarieModele;
using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrarePersonalMedical:IStocarePersonalMedical
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        public List<PersonalMedical> GetPersonal()
        {
            var result = new List<PersonalMedical>();
            var dsPersonal = SqlDBHelper.ExecuteDataSet("select * from personal_medical_ag", CommandType.Text);

            foreach (DataRow linieBD in dsPersonal.Tables[PRIMUL_TABEL].Rows)
            {

                result.Add(new PersonalMedical(linieBD));
            }
            return result;
        }

        public PersonalMedical GetPersonal(string id)
        {
            PersonalMedical result = null;
            var dsPersonal = SqlDBHelper.ExecuteDataSet("select * from personal_medical_ag where Id_Personal = :Id_Personal", CommandType.Text,
                new OracleParameter(":Id_Personal", OracleDbType.NVarchar2, id, ParameterDirection.Input));

            if (dsPersonal.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsPersonal.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new PersonalMedical(linieBD);
              
            }
            return result;
        }

        public bool AddPersonal (PersonalMedical p)
        {
            return SqlDBHelper.ExecuteNonQuery(
               "insert into personal_medical_ag VALUES (:Id_Personal, :Nume, :Prenume, :Functie, :Departament, :Id_Laborator)", CommandType.Text,
                new OracleParameter(":Id_Laborator", OracleDbType.NVarchar2,p.Id_Personal, ParameterDirection.Input),
               new OracleParameter(":Nume", OracleDbType.NVarchar2, p.Nume, ParameterDirection.Input),
               new OracleParameter(":Prenume", OracleDbType.NVarchar2, p.Prenume, ParameterDirection.Input),
                new OracleParameter(":Functie", OracleDbType.NVarchar2, p.Functie, ParameterDirection.Input),
                 new OracleParameter(":Departament", OracleDbType.NVarchar2, p.Departament, ParameterDirection.Input),
                  new OracleParameter(":Id_Laborator", OracleDbType.Int32, p.Id_Laborator, ParameterDirection.Input)
           );
        }

        public bool UpdatePersonal(PersonalMedical p)
        {
            return SqlDBHelper.ExecuteNonQuery(
               "UPDATE personal_medical_ag set Id_Personal=:Id_Personal, Nume=:Nume, Prenume=:Prenume, Functie=:Functie, Departament=:Departament, Id_Laborator=:Id_Laborator", CommandType.Text,
                new OracleParameter(":Id_Laborator", OracleDbType.NVarchar2, p.Id_Personal, ParameterDirection.Input),
               new OracleParameter(":Nume", OracleDbType.NVarchar2, p.Nume, ParameterDirection.Input),
               new OracleParameter(":Prenume", OracleDbType.NVarchar2, p.Prenume, ParameterDirection.Input),
                new OracleParameter(":Functie", OracleDbType.NVarchar2, p.Functie, ParameterDirection.Input),
                 new OracleParameter(":Departament", OracleDbType.NVarchar2, p.Departament, ParameterDirection.Input),
                  new OracleParameter(":Id_Laborator", OracleDbType.Int32, p.Id_Laborator, ParameterDirection.Input)
           );
        }
        public bool DeletePersonal(string id)
        {
            return SqlDBHelper.ExecuteNonQuery("DELETE FROM personal_medical_ag where id_personal=:Id_Personal", CommandType.Text, new OracleParameter(":Id_Personal", OracleDbType.NVarchar2, id, ParameterDirection.Input));
        }
        public List<PersonalMedical> GetPersonalOrdonat(string numeColoana, bool ordineCrescatoare)
        {
            var result = new List<PersonalMedical>();

            string query = $"SELECT * FROM personal_medical_ag ORDER BY {numeColoana} {(ordineCrescatoare ? "ASC" : "DESC")}";
            var dsPacienti = SqlDBHelper.ExecuteDataSet(query, CommandType.Text);

            foreach (DataRow linieBD in dsPacienti.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new PersonalMedical(linieBD));
            }

            return result;
        }
    }
}
