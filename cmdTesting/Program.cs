using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace cmdTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //string strCmd;
            //strCmd = "/C C:\\the\\path\\to\\tesseract -l slk C:\\example\\img.jpg C:\\example\\out";
            //System.Diagnostics.Process.Start("CMD.exe", strCmd);   

            //double amount = 0;
            //try
            //{
            //    double.TryParse(string.Format($"{row.Cells[35].Value}", "{0:F}"), out amount);
            //    //amount = amountOut;
            //}
            //catch
            //{ amount = 0; }

            //String file = @"TextFile1.txt";
            //string lines = File.ReadAllText(file);
            //string[] people = lines.Split(new string[] { "\r\n" },
            //                            StringSplitOptions.RemoveEmptyEntries);

            //HashSet<int> hlines = new HashSet<int>();
            //foreach (var item in people)
            //{
            //    if (int.TryParse(item, out int ordernr))
            //    {
            //        if (hlines.Contains(ordernr))
            //            continue;
            //        else
            //        {
            //            Console.WriteLine();
            //            hlines.Add(ordernr);
            //        }
            //    }
            //    Console.WriteLine(item);               
            //}

            //long[] arr = new long[];

           // fizzBuzz(20);
            //Stack myStack = new Stack();
            //myStack.Push("Hello");
            //myStack.Push("World");
            //myStack.Push("!");

            //foreach (var e in myStack)
            //{
            //    Console.WriteLine(e);
            //}
            // Displays the properties and values of the Stack.
            //Console.WriteLine("myStack");
            //Console.WriteLine("\tCount:    {0}", myStack.Count);
            //Console.Write("\tValues:");
            ////PrintValues(myStack);
            ///
            long n = 4;
            int smallestDiv = 0;
            for (long j = n; j > 1; j--)
            {
                if (n % j == 0 && j > 0)
                {
                    smallestDiv = (int)j;
                }
            }
            Console.WriteLine(smallestDiv);

        }

        public static void fizzBuzz(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= n; i++)
            {
                if (i < 1)
                { continue; }

                if (i % 3 == 0 && i % 5 == 0 && i> 0)
                {
                    sb.AppendLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    sb.AppendLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    sb.AppendLine("Fizz");
                }
                else { sb.AppendLine(i.ToString()); }
            }
            Console.WriteLine(sb.ToString().Trim());
        }




        //static List<int> compareTriplets(List<int> a, List<int> b)
        //{
        //    int[] results = new int[] { 0, 0 };

        //    for (int i = 0; i < a.Count; i++)
        //    {
        //        if (a[i] > b[i])
        //        {
        //            //allice wins
        //            results[0]++;
        //        }
        //        else if (a[i] < b[i])
        //        {
        //            //bob wins
        //            results[1]++;
        //        }
        //        else
        //        {
        //            //nobody wins
        //        }
        //    }
        //    return results.ToList<int>();
        //}

        //static long aVeryBigSum(long[] ar)
        //{
        //    long result = 0;
        //    int arrayLength = (int)ar[0];

        //    for (int i = 1; i <= arrayLength; i++)
        //    {
        //        result += (long)ar[i];
        //    }
        //    return result;
        //}
    }
}
