using System;
namespace CsharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {   
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
        }
    }
}
