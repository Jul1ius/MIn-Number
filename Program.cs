using System;

namespace Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int finalNum = int.MaxValue;

            while (num != "Stop")
            {
                int secNum = int.Parse(num);
                if (secNum < finalNum)
                {
                    finalNum = secNum;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(finalNum);
        }
    }
}
