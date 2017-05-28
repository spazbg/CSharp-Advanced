using System;
using System.Collections.Generic;
using System.Linq;

namespace _10SimpleTextEditor
{
    public class SimpleTextEditor
    {
        public static void Main()
        {
            var inputLines = int.Parse(Console.ReadLine());
            var result = new Stack<string>();

            for (int i = 0; i < inputLines; i++)
            {
                var inputParams = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToArray();

                switch (inputParams[0])
                {
                    case "1":
                        {
                            if (result.Any())
                            {
                                var currentText = result.Peek() + inputParams[1];
                                result.Push(currentText);
                            }
                            else
                            {
                                result.Push(inputParams[1]);
                            }
                            break;
                        }
                    case "2":
                        {
                            var currentText = result.Peek();
                            var newString = currentText.Substring(0, currentText.Length - int.Parse(inputParams[1]));
                            result.Push(newString);
                            break;
                        }

                    case "3":
                        {
                            var index = int.Parse(inputParams[1]);
                            var currentText = result.Peek();
                            Console.WriteLine(currentText[index - 1]);
                            break;
                        }
                    case "4":
                        {
                            result.Pop();
                            break;
                        }
                }
            }
        }
    }
}
