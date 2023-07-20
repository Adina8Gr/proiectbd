using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareAnalize:IStocareFactory
    {
        List<Analize> GetAnalize();
        Analize GetAnalize(string id);
        bool AddAnalize(Analize a);

        bool UpdateAnalize(Analize a);
        bool DeleteAnalize(string id);
        List<Analize> GetAnalizeOrdonate(string numeColoana, bool ordineCrescatoare);
    }
}
