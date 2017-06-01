using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static System.Console;
enum Planets
{
    MERCURY = 1, VENUS, EARTH, MARS, JUPITER, SATURN, URANUS, NEPTUNE
}
class Planet
{
    static void Main()
    {

        string name;

        Planets aPlanet;
        WriteLine("Enter a number and the corresponding planet will appear >> ");
        int planetNum = Convert.ToInt32(Console.ReadLine());
        Planets somePlanet = (Planets)planetNum;
        WriteLine(somePlanet);
    }
}
