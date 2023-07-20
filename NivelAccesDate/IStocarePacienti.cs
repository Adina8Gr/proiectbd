using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocarePacienti:IStocareFactory
    {
        List<Pacienti> GetPacienti();
        Pacienti GetPacienti(int id);
        bool AddPacienti(Pacienti p);

        bool UpdatePacienti(Pacienti p);
        bool DeletePacienti(int id);
        bool DeleteSoftPacienti(int id);
        int GetNumarPacienti();
        
        List<Pacienti> GetPacientiOrdonati(string numeColoana, bool ordineCrescatoare);



    }
}

