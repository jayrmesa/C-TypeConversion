// See https://aka.ms/new-console-template for more information

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = "1234";
            byte b = Convert.ToByte(number);
            Console.WriteLine(b);
        }
    }
}