using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static System.Console;

class MilesToKilometers
{
    static void Main()
    {

        double miles;
        string amonutMile;
        double kilo;

        WriteLine("How many miles did you run?");
        amonutMile = ReadLine();
        miles = Convert.ToDouble(amonutMile);
        kilo = miles * 1.6;
        WriteLine("Thats " + kilo + " Kilometers");
    }
}
