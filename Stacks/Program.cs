using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();

            while (s1.Count != 5)
            {
                Console.WriteLine("Add to stack: ");
                s1.Push(Console.ReadLine().ToString());
            }

            Console.WriteLine("\n");

            bool isFound = false;
            if (s1.Contains("3")) {
                while(s1.Count != 0)
                {
                    if (s1.Peek().ToString() == "3")
                    {
                        Console.WriteLine("{0}", s1.Pop());
                        isFound = true;
                    }
                    else if (isFound)
                    {
                        Console.WriteLine("{0}", s1.Pop());
                    }
                    else {
                        s1.Pop();
                    }
                }
            }

            Console.ReadLine();

        }
    }
}
