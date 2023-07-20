using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Laboratoare
    {
        public int Id_Laborator { get; set; }
        public string Nume_Laborator { get; set; }
        public string Adresa { get; set; }
        public long Telefon { get; set; }
        public Laboratoare()
        {

        }
        public Laboratoare(string nume_laborator, string adresa, long telefon, int id_laborator= 0)
        {
            Nume_Laborator = nume_laborator;
            Adresa = adresa;
            Telefon = telefon;
            Id_Laborator = id_laborator;
        }
        public Laboratoare(DataRow linieBd)
        {
            Nume_Laborator = linieBd["nume_laborator"].ToString();
            Adresa = linieBd["adresa"].ToString();
            Telefon=Convert.ToInt64(linieBd["telefon"].ToString());
            Id_Laborator = Convert.ToInt32(linieBd["id_laborator"].ToString());

        }
    }
}
