using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numStack = new Stack<int>();
            numStack.Push(23);
            numStack.Push(42);
            numStack.Push(1000);
            
            Console.WriteLine(numStack.Pop());
            Console.WriteLine(numStack.Pop());
            Console.WriteLine(numStack.Pop());


        }
    }
}
