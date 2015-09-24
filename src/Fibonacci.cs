namespace CSharp.Training
{
    public class Fibonacci
    {
        public string Compute(int n)
        {
            int x = 1;
            int y = 1;
            int z = 0;
            string res = "";
            for (int i = 0; i < n; i++)
            {
                res += " "+y;
                z = x;
                x = y;
                y = y + z;
            }
            return res;
        }
    }
}
