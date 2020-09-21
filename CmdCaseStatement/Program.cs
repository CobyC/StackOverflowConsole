using System;

namespace CmdCaseStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            int colorCode = 4;
            string color = "";
            switch (colorCode)
            {
                case int i when (i > 0 && i <= 3):
                    color = "red";
                    break;
                case int i when (i > 3 && i <= 6):
                    color = "green";
                    break;
                case int i when (i > 6 && i <= 9):
                    color = "blue";
                    break;
            }
            Console.WriteLine("Hello World!");
        }
    }
}
