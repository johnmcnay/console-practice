using System;

namespace knock_knock
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string response;

            do
            {
                Console.WriteLine("Knock knock!");
                response = Console.ReadLine();

            } while (isInvalidResponse(response));







        }

        private static bool isInvalidResponse(string response)
        {
            return (response != "Who's there?");
        }
    }
}
