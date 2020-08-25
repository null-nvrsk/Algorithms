using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string input = "[2/{5*(4+7)}]";

            for (int i = 0; i < input.Length; i++)
            {
                // если это скобка, то поверям ее
                char ch = input[i];
                if (ch == '[' || ch == '{' || ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ']' || ch == '}' || ch == ')')
                {
                    // если закрывающая скобка соответствует последней в стеке, то убираем пару
                    if (
                    (ch == ']' && stack.Peek() == '[') ||
                    (ch == '}' && stack.Peek() == '{') ||
                    (ch == ')' && stack.Peek() == '('))
                    {
                        stack.Pop();
                    }
                    else stack.Push(ch);
                }
            }

            if (stack.Count == 0)
                Console.WriteLine("Скобки расставлены верно");
            else
                Console.WriteLine($"Остались {stack.Count} скобки");

            Console.ReadLine();
        }
    }
}
