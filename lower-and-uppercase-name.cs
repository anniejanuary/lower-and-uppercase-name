using System;

namespace _2._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myname = "Magda";

            string message = "My name is " + myname;

            string capsmessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();

            Console.WriteLine(lowerCaseMessage);
            Console.Read();
        }
    }
}
