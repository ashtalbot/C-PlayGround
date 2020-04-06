using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
   public class StringUtility
    {
       public static string SummText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
            var totalCharacters = 0;

            var sumWords = new List<string>();

            foreach (var word in words)
            {
                sumWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(" ", sumWords) + " ";
        }
    }
}
