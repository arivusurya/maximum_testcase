namespace TestMaximum
{
    class Program
    {
        public static void Main(String[] args)
        {




            maxy<int> test1 = new maxy<int>();
            Console.WriteLine("Test Case(1) ");
            test1.max(5, 4, 3);
            Console.WriteLine("Test Case(2) ");
            test1.max(55, 89, 73);
            Console.WriteLine("Test Case(3) ");
            test1.max(101, 447, 833);

            Console.WriteLine("-----------------");


            maxy<float> test2 = new maxy<float>();
            Console.WriteLine("Test Case(1) ");
            test2.max(5.5F, 4.4F, 3.73F);
            Console.WriteLine("Test Case(2) ");
            test2.max(55.8F, 89.76F, 73.66F);
            Console.WriteLine("Test Case(3) ");
            test2.max(101.56F, 447.01F, 833.09F);

            Console.WriteLine("-------------------");
            maxy<string> test = new maxy<string>();

            Console.WriteLine("Test Case(1) ");
            test.max("Peach", "Apple", "Banana");

            Console.WriteLine("Test Case(2) ");
            test.max("icon", "volume", "shape");

            Console.WriteLine("Test Case(3) ");
            test.max("docter", "lawyer", "sofware.E");


        }
    }
}