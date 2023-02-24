using System;


namespace TestMaximum
{
    class Program
    {
        public static void Main(String[] args)
        {

            testCases<int> test = new testCases<int>();
            Console.WriteLine("Test Case(1) ");
            Console.WriteLine(test.maxi(5, 4, 3));
            Console.WriteLine("Test Case(2) ");
            Console.WriteLine(test.maxi(55, 89, 73));
            Console.WriteLine("Test Case(3) ");
            Console.WriteLine(test.maxi(101, 447, 833));



        }
    }
}