using System;

namespace FinalTest.Bases
{
    public class Multiplication: IOperation
    {
        public Boolean PeutCalculer(string p0)
        {
            return p0.Substring(1, 1) == "*";
        }

        public int Calculer(string s)
        {
            return int.Parse(s.Substring(0, 1)) * int.Parse(s.Substring(2, 1)); ;
        }
    }
}