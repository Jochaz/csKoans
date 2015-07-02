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
    }
}