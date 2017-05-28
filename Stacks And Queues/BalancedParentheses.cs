using System;
using System.Collections.Generic;
using System.Linq;

namespace _07BalancedParentheses
{
    public class BalancedParentheses
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var openedParentheses = new Stack<char>();

            var parenthesesCases = new[] { '(', '[', '{' };

            for (int i = 0; i < input.Length; i++)
            {
                if (parenthesesCases.Contains(input[i]))
                {
                    openedParentheses.Push(input[i]);
                }
                else
                {
                    if (openedParentheses.Count != 0)
                    {
                        if (input[i] == ')')
                        {
                            if (openedParentheses.Peek() == '(')
                            {
                                openedParentheses.Pop();
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else if (input[i] == ']')
                        {
                            if (openedParentheses.Peek() == '[')
                            {
                                openedParentheses.Pop();
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else if (input[i] == '}')
                        {
                            if (openedParentheses.Peek() == '{')
                            {
                                openedParentheses.Pop();
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

            }

            if (!openedParentheses.Any())
            {
                Console.WriteLine("YES");
            }
        }
    }
}