using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();

            Console.WriteLine("Add to stack: ");
            string input = Console.ReadLine().ToString();

            foreach (char inputChar in input)
            {
                s1.Push(inputChar);
            }

            Console.WriteLine("\n");

            while (s1.Count != 0)
            {
                Console.Write("{0}", s1.Pop());
            }

            Console.ReadLine();

        }
    }
}
