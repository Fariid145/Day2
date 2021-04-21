using System;

namespace StringManipulation1
{
    public class Program
    {
        public static string decode(string str)
       {
            Stack<int> integerstack = new Stack<int>();
            Stack<char> stringstack = new Stack<char>();
            string temp = "", result = "";

            
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;

                

                if (char.IsDigit(str[i]))
                {
                    while (char.IsDigit(str[i]))
                    {
                        count = count * 10 + str[i] - '0';
                        i++;
                    }

                    i--;
                    integerstack.Push(count);
                }

                
                else if (str[i] == ']')
                {
                    temp = "";
                    count = 0;

                    if (integerstack.Count > 0)
                    {
                        count = integerstack.Peek();
                        integerstack.Pop();
                    }

                    while (stringstack.Count > 0 &&
                        stringstack.Peek() != '[')
                    {
                        temp = stringstack.Peek() + temp;
                        stringstack.Pop();
                    }

                    if (stringstack.Count > 0 &&
                        stringstack.Peek() == '[')
                    {
                        stringstack.Pop();
                    }

                    
                    for (int j = 0; j < count; j++)
                    {
                        result = result + temp;
                    }

                    // Push it in the character stack.
                    for (int j = 0; j < result.Length; j++)
                    {
                        stringstack.Push(result[j]);
                    }

                    result = "";
                }

                
                else if (str[i] == '[')
                {
                    if (char.IsDigit(str[i - 1]))
                    {
                        stringstack.Push(str[i]);
                    }

                    else
                    {
                        stringstack.Push(str[i]);
                        integerstack.Push(1);
                    }
                }

                else
                {
                    stringstack.Push(str[i]);
                }
            }

            
            while (stringstack.Count > 0)
            {
                result = stringstack.Peek() + result;
                stringstack.Pop();
            }

            return result;
        }

        
        public static void Main(string[] args)
        {
            string str = "3[b2[ca]]";
            Console.WriteLine(decode(str));
        }
        
    }
}