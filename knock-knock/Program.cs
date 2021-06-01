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
            string[] validResponses = { "who's there", "who is there", "who's there?", "who is there?" };
            string validResponse = response.ToLower();

            foreach (string resp in validResponses)
            {
                if (validResponse == resp)
                {
                    return false;
                }
            }
            return true;

        }

        private static bool isInvalidWhoResponse(string response)
        {
            string[] validResponses = { "boo who", "boo who?" };
            string validResponse = response.ToLower();

            foreach (string resp in validResponses)
            {
                if (validResponse == resp)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
