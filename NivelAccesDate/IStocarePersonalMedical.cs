using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
   public interface IStocarePersonalMedical:IStocareFactory
    {
        List<PersonalMedical> GetPersonal();
        PersonalMedical GetPersonal(string id);
        bool AddPersonal(PersonalMedical p);

        bool UpdatePersonal(PersonalMedical p);
        bool DeletePersonal(string id);
        List<PersonalMedical> GetPersonalOrdonat(string numeColoana, bool ordineCrescatoare);
    }
}
