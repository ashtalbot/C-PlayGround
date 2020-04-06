using System;
using System.Collections.Generic;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is an example of a really really really really really long sentence.";
            var summary = StringUtility.SummText(sentence, 25);
            Console.WriteLine(summary);

        }
    }
}
    

        


    

