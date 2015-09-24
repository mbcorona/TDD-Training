namespace CSharp.Training
{
    public class Palindrome
    {
        public bool Compute(string cad)
        {
            for (int i = 0; i < (cad.Length / 2); i++)
            {
                if (cad[i] != cad[cad.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
