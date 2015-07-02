using System;

namespace FinalTest.Bases
{
    public class Calculatrice
    {
        private IOperation[] _uneOperation;

        public Calculatrice(IOperation[] operations)
        {
            _uneOperation = operations;
        }

        public int Calculer(string p0)
        {
            foreach (var operation  in _uneOperation)
            {
                if (operation.PeutCalculer(p0))
                {
                    return operation.Calculer(p0);
                }
            }

            //Valeur par défaut au cas où
            return 0;
        }
    }
}