using System;
using System.Collections.Generic;

namespace longest_substring_without_repeating_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.Write(LongestSubstringWithoutRepeatingChars(input));
            Console.WriteLine("Hello World!");
        }

        public static int LongestSubstringWithoutRepeatingChars(string str)
        {
            int max = 0;
            int i = 0, j = 0;

            HashSet<char> hash = new HashSet<char>();
            while(j < str.Length)
            {
                if (!hash.Contains(str[j]))
                {
                    hash.Add(str[j]);
                    j++;
                    max = Math.Max(hash.Count, max);
                }
                else
                {
                    hash.Remove(str[i]);
                    i++;
                }
            }

            return max;
        }
    }
}
