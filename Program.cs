using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 11;
            int count = 11;
            float totalPrice = 10.99f;
            char character = 'm';
            string firstName = "Max";
            bool isWorking = false;

            Console.WriteLine(number + count + totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(firstName[1]);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue); 
        }
    }
}
