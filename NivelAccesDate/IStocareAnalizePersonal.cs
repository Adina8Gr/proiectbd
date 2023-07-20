using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareAnalizePersonal:IStocareFactory
    {
        List<AnalizePersonal> GetAnaliPers();
        AnalizePersonal GetAnaliPers(string ids,int id);
        bool AddAnaliPers(AnalizePersonal a);

        bool UpdateAnaliPers(AnalizePersonal a);
    }
}
