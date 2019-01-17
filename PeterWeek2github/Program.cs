using System;

namespace peter_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            var red = new Method("roy", 17);
            Console.WriteLine(red.AddNumbers());
            Console.ReadLine();
        }
    }

    class Method
    {
        public int AddNumbers()
        {
            int a = 0;
            for (int i = 618; i >= 211; i = i - 18)
            {
                a = a + i;
            }
            Console.WriteLine("Sum of numbers between 618 to 211 that are deducted by 18 is " + a);
            return a;
        }

        public Method()
        {
            Console.WriteLine("I am in the no ARGUMENTS. ");
        }
        public Method(string a, int b)
        {
            Console.WriteLine("{0},{1}", a, b);
            Console.ReadLine();
        }
    }
}