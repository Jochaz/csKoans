using System;
using System.Collections.Generic;

namespace FinalTest.Patterns
{
    public class CompteBancaire: IEvenementMetier
    {
        private string _numCompte;

        public CompteBancaire(CompteCréé compteCréé)
        {
            this._numCompte = compteCréé.NumDeCompte;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(_numCompte, montantDepot, dateDepot);
        }
    }
}