using System;

namespace FinalTest.Patterns
{
    public class BalanceNégativeDétectée : IEvenementMetier
    {
        private string _numéroDeCompte;
        private Montant _montant;
        private DateTime _dateRetrait;

        public BalanceNégativeDétectée(string numéroDeCompte, Montant montant, DateTime dateRetrait)
        {
            this._numéroDeCompte = numéroDeCompte;
            this._montant = montant;
            this._dateRetrait = dateRetrait;
        }

        public override bool Equals(object obj)
        {
            BalanceNégativeDétectée balanceNégativeDétectée = obj as BalanceNégativeDétectée;

            return balanceNégativeDétectée != null && ((balanceNégativeDétectée._numéroDeCompte == this._numéroDeCompte) &&
                                                       (balanceNégativeDétectée._montant == this._montant &&
                                                        balanceNégativeDétectée._dateRetrait == this._dateRetrait));
        }
    }
}