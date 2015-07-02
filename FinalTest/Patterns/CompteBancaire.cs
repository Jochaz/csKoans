using System;
using System.Collections.Generic;

namespace FinalTest.Patterns
{
    public class CompteBancaire: IEvenementMetier
    {

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }
    }
}