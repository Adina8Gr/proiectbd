using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LibrarieModele
{
    public class BuletinAnalize
    {
        public int Id_Buletin { get; set; }
        public DateTime Data_recoltarii { get; set; }
        public DateTime Data_Rezultate { get; set; }
        public int Id_Pacient { get; set; }
        public string Id_Personal { get; set; }
        public virtual Pacienti Pacienti { get; set; }
        public virtual PersonalMedical PersonalMedical { get; set; }    
        public BuletinAnalize() { }
        public BuletinAnalize(DateTime data_recoltarii, DateTime data_rezultate, int id_pacient, string id_personal, int id_buletin=0)
        {
            Data_recoltarii = data_recoltarii;
            Data_Rezultate= data_rezultate;
            Id_Personal = id_personal;
            Id_Buletin = id_buletin;
            Id_Pacient = id_pacient;
        }
        public BuletinAnalize(DataRow linieBd)
        {
            Data_recoltarii = Convert.ToDateTime(linieBd["data_recoltarii"].ToString());
            Data_Rezultate = Convert.ToDateTime(linieBd["data_rezultate"].ToString());
            Id_Pacient = Convert.ToInt32(linieBd["id_pacient"].ToString());
            Id_Personal = linieBd["id_personal"].ToString();
            Id_Buletin = Convert.ToInt32(linieBd["id_buletin"].ToString());
        }
    }
}
