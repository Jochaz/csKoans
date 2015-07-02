using System;

namespace FinalTest.Patterns
{
    public class Montant
    {

        public Montant(int i)
        {
            UnMontant = i;
        }

        public int UnMontant { get; set; }


        public override bool Equals(object obj)
        {
            Montant unAutreMontant = obj as Montant;
            return unAutreMontant == null || unAutreMontant.UnMontant == this.UnMontant;
        }
    }
}