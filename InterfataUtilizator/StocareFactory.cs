/*using NivelAccesDate;
using System;
using System.Collections.Generic;
using System.Configuration;
using LibrarieModele;

namespace InterfataUtilizator
{
    /// <summary>
    /// Factory Design Pattern
    /// </summary>
    public class StocareFactory
    {
        public IStocareFactory GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":

                        if (tipEntitate == typeof(Pacienti))
                        {
                            return new AdministrarePacienti();
                        }
                        if (tipEntitate == typeof(BuletinAnalize))
                        {
                            return new AdministrareBuletinAnalize();
                        }
                        if (tipEntitate == typeof(Analize))
                        {
                            return new AdministrareAnalize();
                        }
                        if (tipEntitate == typeof(PersonalMedical))
                        {
                            return new AdministrarePersonalMedical();
                        }
                        if (tipEntitate == typeof(Laboratoare))
                        {
                            return new AdministrareLaboratoare();
                        }
                        if (tipEntitate == typeof(Rezultat))
                        {
                            return new AdministrareRezultat();
                        }
                        if (tipEntitate == typeof(AnalizePersonal))
                        {
                            return new AdministrareAnalizePersonal();
                        }
                        break;

                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}*/
using NivelAccesDate;
using System;
using System.Configuration;
using LibrarieModele;

namespace InterfataUtilizator
{
    public class StocareFactory : IStocareFactory
    {
        public IStocarePacienti GetTipStocarePacienti()
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    case "BazaDateOracle":
                        return new AdministrarePacienti();
                    case "BIN":
                        // Instantiate a class that saves data in a binary file
                        break;
                }
            }
            return null;
        }

        public IStocareBuletinAnalize GetTipStocareBuletinAnalize()
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    case "BazaDateOracle":
                        return new AdministrareBuletinAnalize();
                    case "BIN":
                        // Instantiate a class that saves data in a binary file
                        break;
                }
            }
            return null;
        }

        public IStocareRezultat GetTipStocareRezultat()
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    case "BazaDateOracle":
                        return new AdministrareRezultat();
                    case "BIN":
                        // Instantiate a class that saves data in a binary file
                        break;
                }
            }
            return null;
        }

        public IStocarePersonalMedical GetTipStocarePersonalMedical()
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    case "BazaDateOracle":
                        return new AdministrarePersonalMedical();
                    case "BIN":
                        // Instantiate a class that saves data in a binary file
                        break;
                }
            }
            return null;
        }

        public IStocareLaboratoare GetTipStocareLaboratoare()
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    case "BazaDateOracle":
                        return new AdministrareLaboratoare();
                    case "BIN":
                        // Instantiate a class that saves data in a binary file
                        break;
                }
            }
            return null;
        }

        public IStocareAnalize GetTipStocareAnalize()
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    case "BazaDateOracle":
                        return new AdministrareAnalize();
                    case "BIN":
                        // Instantiate a class that saves data in a binary file
                        break;
                }
            }
            return null;
        }
    }
}

