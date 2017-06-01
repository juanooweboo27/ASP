using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    using static System.Console;
    class Twitter
    {
        static void Main(string[] args)
        {
            string post;
            int length;
            WriteLine("Enter a post");
            post = ReadLine();
            length = post.Length;
            if (length > 140)
                WriteLine("Too many characters.");
            else
                WriteLine("Post?");

        }
    }
}
