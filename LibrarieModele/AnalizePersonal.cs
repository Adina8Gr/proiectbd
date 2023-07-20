using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibrarieModele
{
    
   public class AnalizePersonal
    {
        public string Id_Analiza { get; set; }  
        public string Id_Personal { get; set; }

        public AnalizePersonal() { }
        public AnalizePersonal(string id_analiza, string id_personal)
        {
            Id_Analiza = id_analiza;
            Id_Personal = id_personal;

        }
        public AnalizePersonal(DataRow linieBd)
        {
            Id_Analiza = linieBd["id_analiza"].ToString();
            Id_Personal = linieBd["id_personal"].ToString();

        }
    }
}
