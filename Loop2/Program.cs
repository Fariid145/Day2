using System;

namespace Loop2
{
    class Program
    {
        static void Main(string[] args)
        {

            solve();
        }
        public static double solve()
        {
            double sum = 0, average = 0;
        Console.WriteLine("Enter numbers");
            int num = Convert.ToInt16(Console.ReadLine());
        double[] number = new double[num];

            for(int i = 0; i < number.Length; i ++)
            {
                Console.Write("Number {0}: ", i + 1);
                number[i] = Convert.ToDouble(Console.ReadLine());
                sum += number[i];
            }
    average = sum / number.Length;
            Console.WriteLine("The sum is:" + sum);
            Console.WriteLine("The Average is:" + average);
        }
    }
}
