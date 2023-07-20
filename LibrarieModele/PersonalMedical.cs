using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LibrarieModele
{
   public class PersonalMedical
    {
        public string Id_Personal { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Functie { get; set; }
        public string Departament { get; set; }
        public int Id_Laborator { get; set; }
        public PersonalMedical() { }
        public PersonalMedical(int id_laborator, string nume, string prenume, string functie, string departament, string id_personal=null)
        {
            Id_Laborator = id_laborator;
            Nume = nume;
            Prenume = prenume;
            Functie = functie;
            Departament = departament;
            Id_Personal = id_personal;
        }
        public PersonalMedical(DataRow linieBd)
        {
            Id_Laborator = Convert.ToInt32(linieBd["id_laborator"].ToString());
            Nume=linieBd["nume"].ToString();
            Prenume = linieBd["prenume"].ToString();
            Functie = linieBd["functie"].ToString();
            Departament=linieBd["departament"].ToString();
            Id_Personal=linieBd["id_personal"].ToString();

            
        }

    }
}
