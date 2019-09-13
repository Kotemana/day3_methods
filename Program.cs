using System;

namespace try4
{
    class Program
    {
        static void Main(string[] args)
        {
            string riddleMessage = "Who goes on morning on 4, on day on 2, on evening on 3";
            Riddle(riddleMessage, "human", 4);

            string harderRiddle = "2 ends 2 rings and a nail in the middle";
            Riddle(harderRiddle, "scissors", 2);

            Riddle("Pear hangs, wtf?", "bulb", 3);

            Console.WriteLine("all riddles solved");
            Console.ReadLine();
        }

        static void Riddle(string riddleText, string rightAnswer, int attemps)
        {
            Console.WriteLine("Here is the riddle:");
            string answer="";
            string isRight = "You are right, right answer is";
            while (answer != rightAnswer)
            {
                
                if (attemps == 0)
                {
                    isRight = "No more attempts, right answer was ";
                    break;
                }
                Console.WriteLine($"You have {attemps} attempts left");
                Console.WriteLine($"{riddleText}");
                answer=Console.ReadLine();
                attemps--;
            }
            Console.WriteLine($"{isRight} {rightAnswer}");

        }

    }
}