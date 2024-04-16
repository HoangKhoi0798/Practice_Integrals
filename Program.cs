using System.Diagnostics.Metrics;

namespace Practice_Integrals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hoang Khoi Gia Nguyen
            // 04/16/2024
            // Practice - Integrals
            Console.WriteLine("Practice - Integrals");
            Console.WriteLine();

            Part1();
            Console.WriteLine();
            Part2();

        }
        public static void Part1()
        {
            Console.Write("Enter first number: ");

            int num1 = int.Parse(Console.ReadLine());


            Console.Write("Enter second number: ");

            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");

            int num3 = int.Parse(Console.ReadLine());


            int q1 = num1 + num2;

            int q2 = num3 - num1 + num2;

            int q3 = num3 * num2 - num3;

            int q4 = num1 / num3 - num1;

            int q5 = num3 + num3 - num2 * q2;


            Console.WriteLine($"1.{num1} + {num2} = {q1}");
            Console.WriteLine($"2.{num3} - {num1} + {num2} = {q2}");
            Console.WriteLine($"3.{num3} * {num2} - {num3} = {q3}");
            Console.WriteLine($"4.{num1} / {num3} - {num1} = {q4}");
            Console.WriteLine($"5.{num3} + {num3} - {num2} * {q2} = {q5}");
            Console.WriteLine();

            int q6 = q1 * q3;
            
            int q7 = q2 / q4;

            int q8 = q5 + q1 + num2;

            int q9 = q3 - q6 + num1 * q4;

            int q10 = q3 * q2 + q4 + num2 - q6 / q8;
            Console.WriteLine();

            Console.WriteLine($"6.{q1} * {q3} = {q6}");
            Console.WriteLine($"7.{q2} / {q4} = {q7}");
            Console.WriteLine($"8.{q5} + {q1} + {num2} = {q8}");
            Console.WriteLine($"9.{q3} - {q6} + {num1} * {q4} = {q9}");
            Console.WriteLine($"10.{q3} * {q2} + {q4} + {num2} - {q6} / {q8} = {q10}");

        }

        public static void Part2()
        {
            Console.WriteLine("Samantha runs a small bakery. In one day, she bakes 5 batches of cookies, with each batch containing 24 cookies. She sells each cookie for $2. At the end of the day, she gives away 10 cookies to her neighbors and had to throw away 8 cookies that were accidentally burnt. How much money did Samantha make from selling the cookies after giving away and throwing away some of them?");
            Console.WriteLine();

            int cookieSingleCost = 2;

            int cookieBatchNum = 24;

            int cookieBatchCost = cookieSingleCost * cookieBatchNum;

            int cookie5BatchNum = cookieBatchNum * 5;

            int cookie5BatchCost = cookie5BatchNum * cookieSingleCost;

            int cookieGift = 10;

            int cookieGiftValue = cookieGift * cookieSingleCost;

            int cookieThrown = 8;

            int cookieThrownValue = cookieThrown * cookieSingleCost;

            int cookieEarnValue = cookie5BatchCost - cookieGiftValue - cookieThrownValue;

            Console.WriteLine($"Cost of a single cookie:${cookieSingleCost}");
            Console.WriteLine($"Number of cookies in a batch: {cookieBatchNum}");
            Console.WriteLine($"Cost for a batch of cookies: ${cookieBatchCost}");
            Console.WriteLine($"Total cookies in 5 batches: {cookie5BatchNum}");
            Console.WriteLine($"Total cost for 5 batches of cookies: ${cookie5BatchCost}");
            Console.WriteLine($"Number of cookies given away: {cookieGift}");
            Console.WriteLine($"Cost of cookies given away: ${cookieGiftValue}");
            Console.WriteLine($"Number of cookies thrown away: {cookieThrown}");
            Console.WriteLine($"Cost of cookies thrown away: ${cookieThrownValue}");
            Console.WriteLine($"Total earnings after giving away and throwing away some cookies: ${cookieEarnValue}");


        }
    }
}
