using System.Runtime.CompilerServices;

namespace FinalTest
{
    public class TypeReference
    {
        private int _valeur;

        public TypeReference(int i)
        {
            _valeur = i;
        }

        public override bool Equals(object obj)
        {
            var unType = obj as TypeReference;

            //Alt+Enter m'a créé ça !
            return unType == null || unType._valeur == this._valeur;
        }
    }
}