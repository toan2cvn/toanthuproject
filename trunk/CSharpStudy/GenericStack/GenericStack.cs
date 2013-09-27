using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericStack
{
    class GenericStack<T>
    {

        readonly T[] stack = new T[10];
        int pos;

        public void Push(T value)
        {
            stack[pos++] = value;
        }

        public T Pop()
        {
            T output = stack[--pos];
            stack[pos] = default(T);
            return output;
        }
    }

    class Generic
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            GenericStack<int> stackInt = new GenericStack<int>();
            stackInt.Push(2);
            stackInt.Push(5);
            stackInt.Push(1);
            int num = stackInt.Pop();

            GenericStack<string> stackString = new GenericStack<string>();
            stackString.Push("Monkey");
            stackString.Push("Lion");
            stackString.Push("Pig");

            string str = stackString.Pop();

            Generic gen = new Generic();
            int num1 = 3;
            int num2 = 7;
            gen.Swap<int>(ref num1, ref num2);

        }
    }
}
