using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static System.Console;

class PayRoll
{
    static void Main()
    {

        string name, sSN, hourPay, hoursWorked;
        int first, second, gross;
        Write("Enter your name... ");
        name = ReadLine();
        Write("Hello {0}! Enter SSN... ", name);
        sSN = ReadLine();
        Write("enter hourly pay... ");
        hourPay = ReadLine();
        first = Convert.ToInt32(hourPay);
        Write("enter hourls worked... ");
        hoursWorked = ReadLine();
        second = Convert.ToInt32(hoursWorked);
        gross = first * second;
        WriteLine("Gross pay:{0} ", gross);
        double fed = gross * 0.15;
        WriteLine("Federal withholding tax:{0} ", fed);
        double state = gross * .05;
        WriteLine("State Withholding Tax:{0} ", state);
        double net = gross - state + fed;
        WriteLine("Net Pay:{0}", net);

    }
}
