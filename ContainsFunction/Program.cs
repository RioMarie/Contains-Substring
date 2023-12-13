using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Contains("HelloWorld", "Hello"));
            Console.ReadLine();
        }

        public static bool Contains(string baseString, string str)
        {
            // Iterate through the baseString
            for (var i = 0; i < baseString.Length; i++)
            {
                // Check if baseString contains str
                if(Substring(baseString, i, str.Length) == str) { return true; }

            }
            return false;
        }

        public static string Substring(string str, int start, int end)
        {
            // If end is greater than the length of str, then set the end to str's length - 1
            if (str.Length-1 < end) { end = str.Length - 1; }
            // If start is less than 0 then set the start to 0
            if (start < 0) { start = 0; }
            if (start == 0) { end = end - 1; }

            var substring = "";

            for (var i = start; i <= end; i++) 
            {
                substring += str[i]; // Append to the substring
            }

            return substring;
        }
    }
}