using System;

namespace FinalTest.Patterns
{
    public class RetraitRéalisé : IEvenementMetier
    {
        private string _numeroDeCompte;
        private Montant _montantRetrait;
        private DateTime _dateRetrait;

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            _numeroDeCompte = numéroDeCompte;
            _montantRetrait = montantRetrait;
            _dateRetrait = dateRetrait;
        }


        public override bool Equals(object obj)
        {
            RetraitRéalisé retraitRéalisé = obj as RetraitRéalisé;
            return retraitRéalisé != null && (retraitRéalisé._numeroDeCompte == this._numeroDeCompte &&
                                              (retraitRéalisé._montantRetrait == this._montantRetrait &&
                                               retraitRéalisé._dateRetrait == this._dateRetrait));
        }
    }
}