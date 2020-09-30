using System;
using System.IO;

namespace StackOverflowConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age;
            //Console.Write("Please input your age: ");
            //age = Convert.ToInt32(Console.ReadLine());
            //Console.Write(age);
            //Console.Write("\n");

            //if (age < 18)
            //{
            //    Console.Write("You cannot cast your vote!");
            //}
            //else
            //    Console.Write("You can cast your vote!");
            //{

            //}

            try
            {                               
                TextReader tr = Console.In;
                char[] buffer = new char[4];
                tr.Read(buffer, 0, 4);
                string consoleOutput = new string(buffer);
                if (consoleOutput != 18.ToString())
                {
                    Console.WriteLine($"Expected 18, you entered {consoleOutput}");
                }
            }
            catch (Exception e)
            {

                throw;
            }


        }
    }
}
