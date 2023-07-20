using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareLaboratoare:IStocareFactory
    {
        List<Laboratoare> GetLaboratoare();
        Laboratoare GetLaboratoare(int id);
        bool AddLaboratoare(Laboratoare l);

        bool UpdateLaboratoare(Laboratoare l);
        bool DeleteLaboratoare(int id);
        List<Laboratoare> GetLaboratoareOrdonate(string numeColoana, bool ordineCrescatoare);
    }
}
