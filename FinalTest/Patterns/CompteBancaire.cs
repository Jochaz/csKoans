using System;
using System.Collections.Generic;
using FinalTest.Tests;

namespace FinalTest.Patterns
{
    public class CompteBancaire: IEvenementMetier
    {
        private string _numCompte;

        public CompteBancaire(CompteCréé compteCréé)
        {
            this._numCompte = compteCréé.NuméroDeCompte;
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