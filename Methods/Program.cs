using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(20,30);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            //Console.WriteLine(result);
            Console.WriteLine(Multipy(2,4));
            Console.WriteLine(Multipy(2, 4,3));
            Console.WriteLine(Add4(2,3,4,5,6,1));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        static int add3(out int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multipy(int number1,int number2)
        {
            return number1 * number2;

        }
        //metodların overload olması
        static int Multipy(int number1, int number2,int number3)
        {
            return number1 * number2* number3;

        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
