using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMonth
{
    using static System.Console;
    class Program
    {

        static void Main(string[] args)
        {
            int month;
            Write("Enter a number correspnding with a month.");
            month = Convert.ToInt32(ReadLine());
            /*
            if (month >= 1 && month <= 12)
                Write("This is a valid Month.");
            else 
                Write("This is a valid month.");
        }
        */
            switch (month)
            {
                case 1:
                    WriteLine("January is a valid month!");
                    break;
                case 2:
                    WriteLine("February is a valid month!");
                    break;
                case 3:
                    WriteLine("March is a valid month!");
                    break;
                case 4:
                    WriteLine("April is a valid month!");
                    break;
                case 5:
                    WriteLine("May is a valid month!");
                    break;
                case 6:
                    WriteLine("June is a valid month!");
                    break;
                case 7:
                    WriteLine("July is a valid month!");
                    break;
                case 8:
                    WriteLine("August is a valid month!");
                    break;
                case 9:
                    WriteLine("September is a valid month!");
                    break;
                case 10:
                    WriteLine("October is a valid month!");
                    break;
                case 11:
                    WriteLine("November is a valid month!");
                    break;
                case 12:
                    WriteLine("December is a valid month!");
                    break;
                default:
                    WriteLine("ERROR! That is not a month!");
                    break;
            }
        }
    }
}
