using System;
using System.Collections.Generic;

namespace FinalTest.Patterns
{
    public class CompteBancaire: IEvenementMetier
    {
        private string _numCompte;
        private CompteCréé compteCréé;
        private DépotRéalisé dépotRéalisé;

        public CompteBancaire(CompteCréé compteCréé)
        {
            this._numCompte = compteCréé.NumDeCompte;
        }

        public CompteBancaire(CompteCréé compteCréé, DépotRéalisé dépotRéalisé)
        {
            // TODO: Complete member initialization
            this.compteCréé = compteCréé;
            this.dépotRéalisé = dépotRéalisé;
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

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            yield return new RetraitRéalisé(_numCompte, montantRetrait, dateRetrait);
        }
    }
}