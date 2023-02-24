using System;


namespace TestMaximum
{
    class Program
    {
        public static void Main(String[] args)
        {

           
            max<int> test1 = new max<int>();
            Console.WriteLine("Test Case(1) ");
            Console.WriteLine(test1.maxex(5, 4, 3));
            Console.WriteLine("Test Case(2) ");
            Console.WriteLine(test1.maxex(55, 89, 73));
            Console.WriteLine("Test Case(3) ");
            Console.WriteLine(test1.maxex(101, 447, 833));

            Console.WriteLine("---------------------------------");


            max<float> test2 = new max<float>();
            Console.WriteLine("Test Case(1) ");
            Console.WriteLine(test2.maxex(5.5F, 4.4F, 3.73F));
            Console.WriteLine("Test Case(2)");
            Console.WriteLine(test2.maxex(55.8F, 89.76F, 73.66F));
            Console.WriteLine("Test Case(3) ");
            Console.WriteLine(test2.maxex(101.56F, 447.01F, 833.09F));

            Console.WriteLine("-------------------------------------------");
            max<string> test = new max<string>();

            Console.WriteLine("Test Case(1) ");
            Console.WriteLine(test.maxex("Peach", "Apple", "Banana"));

            Console.WriteLine("Test Case(2) ");
            Console.WriteLine(test.maxex("icon", "volume", "shape"));


            Console.WriteLine("Test Case(3) ");
            Console.WriteLine(test.maxex("docter", "lawyer", "sofware.E"));


        }
    }
}