using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static System.Console;

class Tests
{
    static void Main()
    {

        string test1, test2, test3, test4, test5;
        double testNum, testNum2, testNum3, testNum4, testNum5;

        Write("Enter test score 1... ");
        test1 = ReadLine();
        testNum = Convert.ToDouble(test1);
        Write("Enter test score 2... ");
        test2 = ReadLine();
        testNum2 = Convert.ToDouble(test2);
        Write("Enter test score 3... ");
        test3 = ReadLine();
        testNum3 = Convert.ToDouble(test3);
        Write("Enter test score 4... ");
        test4 = ReadLine();
        testNum4 = Convert.ToDouble(test4);
         Write("Enter test score 5... ");
        test5 = ReadLine();
        testNum5 = Convert.ToDouble(test5);
        double avg = testNum + testNum2 + testNum3 + testNum4 + testNum5 / 5;
        WriteLine("The average of your test scores is: {0}", avg);
    }
}
