using System;

namespace try4
{
    class Program
    {
        static void Main(string[] args)
        {
            string riddleMessage = "Who goes on morning on 4, on day on 2, on evening on 3";
            Riddle(riddleMessage, "human");

            string harderRiddle = "2 ends 2 rings and a nail in the middle";
            Riddle(harderRiddle, "scissors");

            Riddle("Pear hangs, wtf?", "bulb");

            Console.WriteLine("all riddles solved");
            Console.ReadLine();
        }

        static void Riddle(string riddleText, string rightAnswer)
        {
            Console.WriteLine("Here is the riddle:");
            string answer="";
            while (answer != rightAnswer)
            {
                Console.WriteLine($"{riddleText}");
                answer=Console.ReadLine();
            }
            Console.WriteLine($"Right, it's {rightAnswer}");

        }
    }
}