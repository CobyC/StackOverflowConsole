using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PassCharBeginEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string thevalue = "ThisValue1234";

            if (thevalue.Length < 5)
                Console.WriteLine("not long enough");
            else
            {
                Regex regPat = new Regex("(^.{2}).+(.{2}$)");
                var match = regPat.Match(thevalue);
                if (match.Groups.Count > 0)
                {
                    var result = $"{match.Groups[1].Value}***{match.Groups[2].Value}";
                    Console.WriteLine(result);

                    //same length
                    var starArray = Enumerable.Repeat("*", thevalue.Length - 4).ToArray();
                    var starString = string.Concat(starArray);

                    StringBuilder sb = new StringBuilder();
                    sb.Append(match.Groups[1]);
                    sb.Append(starString);
                    sb.Append(match.Groups[2]);
                    result = $"{match.Groups[1]}{starString}{match.Groups[2]}";
                    result = sb.ToString();
                    Console.WriteLine(result);
                }
            }
        }


    }
}
