using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            Stack s2 = new Stack();

            while (s1.Count != 5)
            {
                Console.WriteLine("Add to stack: ");
                s1.Push(Console.ReadLine().ToString());
            }

            Console.WriteLine("\n");

            while(s1.Count != 0) {
                s2.Push(s1.Pop());                
            }

            while (s2.Count != 0)
            {
                Console.WriteLine("{0}", s2.Peek());
                s1.Push(s2.Pop());
            }

            Console.WriteLine("\n");

            while (s1.Count != 0)
            {
                Console.WriteLine("{0}", s1.Peek());
                s2.Push(s1.Pop());
            }

            Console.ReadLine();

        }
    }
}
