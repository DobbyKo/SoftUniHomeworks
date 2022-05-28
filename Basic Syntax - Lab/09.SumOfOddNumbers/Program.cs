using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main()
        {
            int OddNumsCount = int.Parse(Console.ReadLine());
            int oddNumsSum = 0;
            

            for (int i = 0; i < OddNumsCount ; i++)
            {
                int currentOddNum = 1 + (i * 2);
                Console.WriteLine(currentOddNum);
                oddNumsSum += currentOddNum;
                                
            }
            Console.WriteLine($"Sum: {oddNumsSum}");
        }
    }
}
