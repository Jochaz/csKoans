using System;

namespace FinalTest.Patterns
{
    public class DépotRéalisé:IEvenementMetier
    {
        private string _num;
        private Montant _montantDepot;
        private DateTime _dateDepot;

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            _num = numéroDeCompte;
            _montantDepot = montantDepot;
            _dateDepot = dateDepot;
        }
        public Montant MontantDepot
        {
            get { return _montantDepot; }
        }
        public override bool Equals(object obj)
        {
            DépotRéalisé dépotRéalisé = obj as DépotRéalisé;

            return (dépotRéalisé == null || dépotRéalisé._num == this._num) &&
                   ((dépotRéalisé == null || dépotRéalisé._montantDepot == this._montantDepot) &&
                    (dépotRéalisé == null || dépotRéalisé._dateDepot == this._dateDepot));
        }
    }
}