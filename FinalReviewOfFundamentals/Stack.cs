using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReviewOfFundamentals
{
    internal class Stack
    {
        Stack<int> stack = new Stack<int>();
        
        public Stack()
        {
            Console.WriteLine("Pushed into the stack");
            Push(1);
            Push(2);
            Push(3);
            Console.WriteLine("Popped from the stack");
            Pop();
            Console.WriteLine("Peeked from the stack");
            Peek();
        }
        public void Push(int value)
        {   
            Console.WriteLine(value);
            stack.Push(value);
        }
        public int Pop()
        {
            int popElemet = stack.Pop();
            Console.WriteLine(popElemet);
            return popElemet;
        }
        public int Peek()
        {
            int peekElement = stack.Peek();
            Console.WriteLine(peekElement);
            return peekElement;
        }
    }
}
