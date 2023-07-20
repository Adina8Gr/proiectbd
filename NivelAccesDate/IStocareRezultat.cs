using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareRezultat:IStocareFactory
    {
        List<Rezultat> GetRezultat();
        Rezultat GetRezultat(int id);
        bool AddRezultat(Rezultat r);

        bool UpdateRezultat(Rezultat r);
        bool DeleteRezultate(int id);
        List<Rezultat> GetRezultateByBuletinId(int idBuletin);
        int GetNumarRezultate();
        List<Rezultat> GetRezultatOrdonat(string numeColoana, bool ordineCrescatoare);
    }
}
