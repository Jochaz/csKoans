namespace FinalTest.Bases
{
    public class Somme: IOperation
    {
        public bool PeutCalculer(string p0)
        {
            return p0.Substring(1, 1) == "+";
        }

        public int Calculer(string s)
        {
            return int.Parse(s.Substring(0, 1)) + int.Parse(s.Substring(2, 1)); ;
        }
    }
}