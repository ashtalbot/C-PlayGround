using System.Text;
using System.Collections.Generic;


namespace StriBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+');
                
                System.Console.WriteLine(builder); 

        }
    }
}
