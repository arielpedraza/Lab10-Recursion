using System;

namespace TowersOfHanoi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Towers of Hanoi!\nEnter a whole number to use as the starting number of disks:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Minimum number of moves\nUsing Recursion (Hanoi(n)): " + Hanoi(n));
            Console.WriteLine("Iteratively using for loop: " + Hanoi2(n));
            Console.WriteLine("Iteratively using Powers ((2^n)-1): " + (int)(Math.Pow(2,n)-1));
            Console.ReadLine();
        }

        public static int Hanoi(int n)
        {
            if (n == 1) return 1;
            return (2 * (Hanoi(n - 1)) + 1);
        }

        public static int Hanoi2(int n)
        {
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                count = count * 2;
            }
            return count - 1;
        }
    }
}
