using System;
using System.Runtime.InteropServices;

namespace _316._Remove_Duplicate_Letters
{
    // Given a string s, remove duplicate letters so that every letter appears once and only once. You must make sure your result is 
    // the smallest in lexicographical order
    // among all possible results.
    internal class Program
    {        
        static void Main(string[] args)
        {
            while(true)
            {
                List<char> doubles = new List<char>();
                List<char> values = new List<char>();
                string? symbols;
                Console.WriteLine("Enter values");
                symbols = Console.ReadLine();
                if (symbols != null)
                {
                    foreach (char s in symbols)
                    {
                        switch (doubles.Contains(s))
                        {
                            case false:
                                doubles.Add(s);
                                values.Add(s);
                                    break;
                        }
                    }
                }   
                var sortValues = values.OrderBy( w => w );
                foreach (var sortValue in sortValues)
                {
                    Console.Write(sortValue);                  
                }
                Console.WriteLine();
            }
        }
        
    }
}