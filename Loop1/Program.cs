using System;

namespace Loop1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, even = 0, odd = 0;
            int[] arr = new int[5];
            Console.Write("Enter any numbers:  ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[1] = Convert.ToInt32(Console.ReadLine());
            }
            for ( int i = 0; i < 5; i ++)
            {
                if (arr[1] % 2 == 0)
                {
                    even = even + arr[i];
                }
                else
                {
                   odd = odd + arr[i]; 
                }
            }
            Console.WriteLine("Sum even is:" + even);
            Console.WriteLine("Sum Odd is:" + odd);
        }
    }
}
