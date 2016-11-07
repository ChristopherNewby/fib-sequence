using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {


        public static void Fibonacci(int a, int b, int counter, int number)
        {

            if (counter < number)
            {
                Console.WriteLine(a);
                Fibonacci(b, a + b, counter + 1, number);
            }
        }

        static int recursiveFac(int num)
        {
            if (num > 0)
            {
                return num * recursiveFac(num - 1);
            }
            return 1;
        }

        class ChrisCustomException : Exception
        {
            public ChrisCustomException(string message)
            {

            }
        }



        static void Main()
        {
            Console.WriteLine("Please enter a number.");
            int y = Convert.ToInt32(Console.ReadLine());
            Fibonacci(0, 1, 1, y);
            Console.ReadLine();



            Console.WriteLine("Please Enter a Number");
            int newNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(recursiveFac(newNum));


            for (int i = newNum; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);

                }
                Console.WriteLine(recursiveFac(i));
            }
            int a = 100;
            try
            {
                if (a > 50)
                {
                    ChrisCustomException ex = new ChrisCustomException("Number is greater than 50");

                    throw ex;
                }
            }
            catch (ChrisCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}


