using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LibrarieModele
{
    public class Rezultat
    {
        public int Id_Rezultat { get; set; }
        public int Id_Buletin { get; set; }
        public string Id_Analiza { get; set; }
        public int Rezultat_Analiza { get; set; }
        public string Comentarii { get; set; }
        public virtual BuletinAnalize BuletinAnalize { get; set; }
        public virtual Analize Analize { get; set; }
        public Rezultat() { }
        public Rezultat(int id_buletin, string id_analiza, int rezultat_analiza, string comentarii, int id_rezultat=0)
        {
            Id_Buletin = id_buletin;
            Id_Analiza = id_analiza;
            Rezultat_Analiza = rezultat_analiza;
            Comentarii = comentarii;
            Id_Rezultat = id_rezultat;
        }
        public Rezultat(DataRow linieBd)
        {
            
            Id_Buletin=Convert.ToInt32(linieBd["id_buletin"].ToString());
            Id_Analiza = linieBd["id_analiza"].ToString();
            Rezultat_Analiza = Convert.ToInt32(linieBd["rezultat_analiza"].ToString());
            Comentarii = linieBd["comentarii"].ToString();
            Id_Rezultat = Convert.ToInt32(linieBd["id_rezultat"].ToString());
        }
    }
}
