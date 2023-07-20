using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareBuletinAnalize:IStocareFactory
    {
        List<BuletinAnalize> GetBuletin();
        BuletinAnalize GetBuletin(int id);
        bool AddBuletin(BuletinAnalize b);

        bool UpdateBuletin(BuletinAnalize b);
        bool DeleteBuletine(int id);
        Rezultat AfiseazaAnalizeBuletin(int i);
        List<BuletinAnalize> GetBuletineByPacientId(int idPacient);
        int GetNumarBuletine();
        List<BuletinAnalize> GetBuletineOrdonate(string numeColoana, bool ordineCrescatoare);
        int GetNrDateBuletin(DateTime d);
    }
}
