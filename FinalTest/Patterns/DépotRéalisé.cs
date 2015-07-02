using System;
using FinalTest.Patterns;

namespace FinalTest.Tests
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
    }
}