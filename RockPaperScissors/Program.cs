using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 4);
            int yourMove;
            Write("Rock = 1, Paper = 2, Scissors = 3");
            WriteLine();
            WriteLine();
            WriteLine();
            Write("Rock!    Paper!   Scissors .....  ");
            yourMove = Convert.ToInt32(ReadLine());
            if (randomNumber == 1)
            {
                Write("I chose rock! ");
            }
            else if (randomNumber == 2)
            {
                Write("I chose paper! ");
            }
            else if (randomNumber == 3)
            {
                Write("I chose scissors! ");
            }
             
            
            if(randomNumber == 1 && yourMove == 1) {
                Write("Tie! ");
            }else if(randomNumber == 1 && yourMove == 2) {
                Write("You win! ");
            }else if(randomNumber == 1 && yourMove == 3) {
                Write("I Win! ");
            }else if(randomNumber == 2 && yourMove == 1) {
                Write("I win! ");
            }else if(randomNumber == 2 && yourMove == 2) {
                Write("Tie! ");
            }else if(randomNumber == 2 && yourMove == 3) {
                Write("You win! ");
            }else if(randomNumber == 3 && yourMove == 1) {
                Write("You win! ");
            }else if(randomNumber == 3 && yourMove == 2) {
                Write("I win! ");
            }else if(randomNumber == 3 && yourMove == 3) {
                Write("Tie! ");
            }
               
            }
        }
    }

