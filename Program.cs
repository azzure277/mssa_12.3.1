using System;
using System.Collections.Generic;
using System.Linq;

namespace mssa_12._3._1
{
    internal class Program
    {
        public static string RemoveDuplicates(string s)
        {
            var stack = new Stack<char>();
            foreach (char c in s)
            {
                if (stack.Count > 0 && stack.Peek() == c)
                    stack.Pop();
                else
                    stack.Push(c);
            }
            return new string(stack.Reverse().ToArray());
        }

        static void Main(string[] args)
        {
            string s = "abbaca";
            string result = RemoveDuplicates(s);
            Console.WriteLine(result); // Output: "ca"
        }
    }
}