using System;


namespace TestMaximum
{
    class Program
    {
        public static void Main(String[] args)
        {

            testCases<string> test = new testCases<string>();
            Console.WriteLine("Test Case(1) ");
            Console.WriteLine(test.maxi("Peach", "Apple", "Banana"));
            Console.WriteLine("Test Case(2) ");
            Console.WriteLine(test.maxi("icon", "volume", "shape"));
            Console.WriteLine("Test Case(3) ");
            Console.WriteLine(test.maxi("docter", "lawyer", "sofware.E"));


        }
    }
}