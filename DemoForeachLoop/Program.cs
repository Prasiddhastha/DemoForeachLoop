using System;
namespace CsharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4 };
            //forloop
            var name = "Prasiddha Shrestha";
            for(var i=0;i<name.Length;i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("\n");
            //foreachloop
            foreach(var character in name)
            {
                Console.WriteLine(character);
            }
            Console.WriteLine("\n");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
