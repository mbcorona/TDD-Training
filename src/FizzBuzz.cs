using System;

namespace CSharp.Training
{
    public class FizzBuzz
    {
        /// <summary>
        /// FizzBuzz Compute Method
        /// * If the number is divisible by three then the result will be "Fizz"
        /// * If the number is divisible by five then the result will be "Buzz"
        /// * If the number is divisible by three and five then the result will be "FizzBuzz"
        /// </summary>
        /// <param name="number">Number to compute</param>
        /// <returns>Computed result</returns>
        public string Compute(int n)
        {
            string res = "";
            if (n % 3 == 0)
                res = "Fizz";
            if (n % 5 == 0)
                res += "Buzz";
            return res.Equals("") ? n.ToString() : res;
        }
    }
}
