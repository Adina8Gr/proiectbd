using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele

{
   public class Pacienti
    {
        public int Id_Pacient { get; set; }    
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public long CNP { get; set; }

        public DateTime Data_nasterii { get; set; }

        public string Sex { get; set; }
        public long Telefon { get; set; }
        public string Adresa { get; set; }

        public Pacienti() { }
        public Pacienti( string nume, string prenume, long cnp, DateTime data_nasterii, string sex, long telefon, string adresa, int id_pacient = 0)
        {

            Id_Pacient = id_pacient;
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
            Data_nasterii = data_nasterii;
            Sex=sex;
            Telefon = telefon;
            Adresa = adresa;

        }

       public Pacienti (DataRow linieBd)
        {
            Id_Pacient=Convert.ToInt32(linieBd["id_pacient"].ToString());
            Nume = linieBd["nume"].ToString();
            Prenume=linieBd["prenume"].ToString ();
            CNP=Convert.ToInt64(linieBd["cnp"].ToString ());
            Data_nasterii = Convert.ToDateTime(linieBd["data_nasterii"].ToString());
            Sex = linieBd["sex"].ToString();
            Telefon = Convert.ToInt64(linieBd["telefon"].ToString());
            Adresa=linieBd["adresa"].ToString();

        }
    }
}
