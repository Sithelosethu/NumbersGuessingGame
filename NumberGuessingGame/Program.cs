using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main (string[] args)
        {
            //  Variables
            string username;
            int number;
            int attempts = 0;

            //Generate random number
            Random random = new Random();
            int answer = random.Next(1, 101);
            
            //Welcome user
            Console.WriteLine("Welcome player");
            Console.WriteLine("Enter username-");
            username = Console.ReadLine();
            Console.WriteLine("We will play Numbers Guessing Game " + username+" \nChoose any number between 1 - 100\n" +
                "If you get it right you win...!!!");
            Console.WriteLine("Go...");

            // Game Loop
            while (true)
            {
               
                while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 100)
                {
                    Console.WriteLine("Invalid input, enter a number between 1 and 100 ");
                }
                attempts++;
                
                if(number == answer)
                {
                    Console.WriteLine("Well done, you got the answer correct");
                    Console.WriteLine($"You did it in {attempts} attempts.");
                    break;
                }
                else if(number > answer)
                {
                    Console.WriteLine("Try lower");
                    
                }
                else if(number < answer)
                {
                    Console.WriteLine("Go higher");
                  
                }
            }
            Console.WriteLine("Thanks for playing...!!");
        }
    }
}