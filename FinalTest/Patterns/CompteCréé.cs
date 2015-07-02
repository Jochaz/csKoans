namespace FinalTest.Patterns
{
    public class CompteCréé : IEvenementMetier
    {
        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            NumDeCompte = numéroDeCompte;
            AutoDeCred = autorisationDeCrédit;
        }

        public string NumDeCompte { get; set; }

        public int AutoDeCred { get; set; }

        public override bool Equals(object obj)
        {

            CompteCréé compteCreeObj = obj as CompteCréé;

            if (compteCreeObj != null && compteCreeObj.NumDeCompte != this.NumDeCompte) return false;
            if (compteCreeObj != null && compteCreeObj.AutoDeCred != this.AutoDeCred) return false;

            return true;

        }
    }
}