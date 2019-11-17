using System;
using System.Linq;

namespace Open_Lab_04._03
{
    class Program
    {
        public static string RemoveFirstLast(string original)
        {

            if (original.Length > 1)
            {
                return original.Substring(1, original.Length - 2);
            }
            else if (original.Length == 1)
            {
                return original;
            }
            return original;

        }   
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(RemoveFirstLast(word));
        }
    }
}
