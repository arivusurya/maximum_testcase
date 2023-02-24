using System;


namespace TestMaximum
{
    class Program
    {
        public static void Main(String[] args)
        {

            TestCases<float> test = new TestCases<float>();
            Console.WriteLine("Test Case(1) ");
            Console.WriteLine(test.maxf(5.5F, 4.4F, 3.73F));
            Console.WriteLine("Test Case(2) ");
            Console.WriteLine(test.maxf(55.8F, 89.76F, 73.66F));
            Console.WriteLine("Test Case(3) ");
            Console.WriteLine(test.maxf(101.56F, 447.01F, 833.09F));



        }
    }
}