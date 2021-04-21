using System;

namespace IfAndElse
{
    public class Lottery
    {
        public static void LotteryMenu()
        {
            int lotto1 = 24;

            int lotto2 = 23;

            int lotto3 = 32;
            
            Console.WriteLine("Enter Three Numbers To Win ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            int Num2 = Convert.ToInt32(Console.ReadLine());

            int Num3 = Convert.ToInt32(Console.ReadLine());

            if (( Num1 == lotto2 || Num1 == lotto3) || (Num2 == lotto1 || Num2 == lotto3) || (Num3 == lotto1 || Num3 == lotto2 ))
            {
                Console.WriteLine("you Won $1,000 in cash");
                Console.WriteLine("Enter any key");
                Console.ReadKey();
            }
            else if((Num2 == lotto1 || Num2 == lotto2 || Num2 == lotto3) && (Num1 == lotto1 || Num1 == lotto2 || Num1 == lotto3) && (Num3 == lotto1 ||Num3 == lotto2 || Num3 == lotto3))
            {
                Console.WriteLine("you Won $3,000 in cash");
                Console.WriteLine("Enter any key");
                Console.ReadKey();
            }
            else if((Num1 == lotto1) && (Num2 == lotto2) && (Num3 ==lotto3))
            {
                Console.WriteLine("you Won $10,000 in cash");
                Console.WriteLine("Enter any key");
                Console.ReadKey();
            }
            else{
                Console.WriteLine("Invalid impute");
            }
        }
    }
}