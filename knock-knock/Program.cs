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

            } while (isInvalidKnockKnockResponse(response));


            bool repeat = false;

            do
            {
                if (repeat)
                {
                    Console.WriteLine("Invalid Response. Please try again.");
                }
                
                Console.WriteLine("Boo.");
                response = Console.ReadLine();
                repeat = true;


            } while (isInvalidWhoResponse(response));


            Console.WriteLine("Don't cry! It's just a joke.");

        }

        private static bool isInvalidKnockKnockResponse(string response)
        {
            return (response != "Who's there?");
        }

        private static bool isInvalidWhoResponse(string response)
        {
            return (response != "Boo who?");
        }
    }
}
