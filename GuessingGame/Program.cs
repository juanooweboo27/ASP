using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 11;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);
            Write("Guess a random number");
            randomNumber = Convert.ToInt32(ReadLine());
            if(randomNumber >= 1 && randomNumber <= 10) {
                Write("Correct ");
            } else if(randomNumber < 1) {
                Write("Too Low ");
            }else if(randomNumber > 10) {
                Write("Too High ");

            }
        }
    }
}
