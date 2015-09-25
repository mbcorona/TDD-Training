namespace CSharp.Training
{
    public class Fibonacci
    {
        public int Compute(int n)
        {
            int x = 0;
            int y = 1;
            int z = 0;
            for (int i = 0; i < n; i++)
            {
                z = x;
                x = y;
                y = y + z;
            }
            return x;
        }
    }
}
