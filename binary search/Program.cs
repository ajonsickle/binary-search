using System;

namespace binary_search
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] x = new int[] { 1, 22, 67, 91 };
            
            int left = 0;

            bool found = false;

            int right = x.Length - 1;

            int a = 0;
            Console.WriteLine("Binary search! Please enter the value you want to search for.");
            int value = Convert.ToInt32(Console.ReadLine());

            while (found == false && left<=right)
            {
                int mid = left + right / 2;
                    if (value > x[mid])
                {
                    left = mid + 1;
                }
                    if (value < x[mid])
                {
                    right = mid - 1;
                }
                    if (value == x[mid])
                {
                    found = true;
                    a = x[mid];
                }
                    
            }
            if (found == true)
            {
                Console.WriteLine(x[a] + " - Found your number!");
            }
            else
            {
                Console.WriteLine("Your number is not in the array!");
            }


        }
    }
}
