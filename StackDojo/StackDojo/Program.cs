using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDojo
{
    class Program
    {
        int size;
        static Stack<int> stack;
        int numbers;

        Program(int size)
        {
            this.size = size;
            stack = new Stack<int>(size);
        }

        void Push(int item)
        {
            if (stack.Count != size)
            {
                stack.Push(item);
            } else
            {
                Console.WriteLine("stack is full");
            }          
        }

        void Pop()
        {
            if (stack.Count != 0)
            {
                stack.Pop();
            } else
            {
                Console.WriteLine("stack is empty");
            }      
        }

        void Peek()
        {
            stack.Peek();
        }

        int SizeOfStack()
        {
            int sizeOfStack = stack.Count();
            return size;
        }

        int GetFreeSpaces()
        {
            
            foreach (int i in stack)
            {
                if(i != null)
                {
                    numbers++;
                }
            }
            return size - numbers;
        }

        static void Main(string[] args)
        {
            Program program = new Program(5);
            program.Push(1);
            program.Push(2);
            program.Push(3);
            program.Pop();
            program.Push(3);
            program.Push(3);
            program.Push(3);
            program.Push(3);
            Console.WriteLine("items:");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }  
            Console.WriteLine("size of stack: " + program.SizeOfStack());
            Console.WriteLine("free spaces: " + program.GetFreeSpaces());
            Console.ReadLine();

        }
    }
}
