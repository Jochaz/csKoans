using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTest.LinQ
{
    public class Nombres
    {
        private IEnumerable<KeyValuePair<string, int>> valeur;

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            this.valeur = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get
            {
                return valeur.Where(x => (x.Value % 2) == 0).Select(x => x.Value);
            } 
        }
    }
}