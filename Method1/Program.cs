using System;

namespace Method1
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number to check: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Reverse of number is:   " + Reverse(num));
        }

        static int Reverse(int num)
        {
            int revnum = 0;
            while (num > 0)
            {
                revnum = revnum * 10 + num % 10;
                num = num / 10;
            }
            return revnum;
        }

       
    }
}