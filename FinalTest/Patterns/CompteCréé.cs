namespace FinalTest.Patterns
{
    public class CompteCréé : IEvenementMetier
    {
        private string _numDeCompte;
        private int _autoDeCred;

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            _numDeCompte = numéroDeCompte;
            _autoDeCred = autorisationDeCrédit;
        }

        public string NuméroDeCompte { get; set; }
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            CompteCréé compteCreeObj = obj as CompteCréé;

            if (compteCreeObj._numDeCompte != this._numDeCompte) return false;
            if (compteCreeObj._autoDeCred != this._autoDeCred) return false;

            return true;

        }
    }
}