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

        public string TexteNombresImpairs
        {
            get
            {
                return valeur.OrderBy(x => x.Value).Where(x => (x.Value % 2) != 0).Select(x => x.Key).Aggregate(String.Empty, (s, s1) => s + ", " + s1).Substring(2);
            }
            
        }

        public string PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get { return valeur.Select(x => x.Key).First(x => x.Length > 5); }
        }
    }
}