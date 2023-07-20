using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibrarieModele
{
    public class Analize
    {
        public string Id_Analiza { get; set; }  
        public string Denumire { get; set; }    
        public string Tip { get; set; }
        public decimal Pret { get; set; }
        public Analize() { }
        public Analize(string denumire, string tip, decimal pret, string id_analiza=null)
        {
            Id_Analiza = id_analiza;
            Tip = tip;
            Pret = pret;
            Denumire = denumire;
        }
        public Analize(DataRow linieBd)
        {
            Id_Analiza=linieBd["id_analiza"].ToString();
            Denumire = linieBd["denumire"].ToString();
            Tip=linieBd["tip"].ToString();
            Pret = Convert.ToDecimal(linieBd["pret"].ToString());  
        }
    }
}
