using System;

namespace cSharpDecimalToBinary2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            int[] rems = new int[10];
            Console.Write("Enter the decimal number...: ");
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                for(i=0; num>0; i++)
                {
                    rems[i] = num % 2;
                    num = num / 2;
                }

                for(i=i-1; i>=0; i--)
                {
                    Console.Write(rems[i]);
                }
            }
        }
    }
}
