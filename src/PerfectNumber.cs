using System.Runtime.InteropServices.ComTypes;

namespace CSharp.Training
{
    public class PerfectNumber
    {
        public bool Compute(int n)
        {
            if (n%2 != 0)
                return false;
            int i, suma=0; 
            for (i = 1; i < n; i++)
            {
                if (n%i == 0)//1 2 3
                    suma += i;//1 3 6
            }
            return suma == n;
        }
    }
}