using System;
using System.Collections.Generic;

namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Adventurer! Please enter your name: ");

            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
                1) John
                2) Paul
                3) George
                4) Ringo
                ",
                4, 20
            );
            Challenge howMuchWood = new Challenge("How much wood could a wood chuck chuck if a wood chuck could chuck wood?", 0, 15);
            Challenge tenTimesTen = new Challenge("What's 10 x 10?", 100, 1);
            Challenge onePlusOne = new Challenge("What's 1 + 1?", 2, 50);


            int minAwesomeness = 0;
            int maxAwesomeness = 100;

            Robe adventurerRobe = new Robe()
            {
                RobeColors = new List<string>()
                {
                    "red", "green", "yellow"
                },
                RobeLength = 42
            };
            Hat adventurerHat = new Hat()
            {
                ShininessLevel = 5
            };
            Adventurer theAdventurer = new Adventurer(Console.ReadLine(), adventurerRobe, adventurerHat);
            Console.WriteLine($"{theAdventurer.GetDescription()}");
            List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle,
                howMuchWood,
                tenTimesTen,
                onePlusOne
            };
            string Play = "y";
            while (Play == "y")
            {
                List<Challenge> selectChallenges = new List<Challenge> { };
                while (selectChallenges.Count < 6)
                {
                    Random random = new Random();
                    int randomChallenges = random.Next(0, 8);
                    if (!selectChallenges.Contains(challenges[randomChallenges]))
                    {
                        selectChallenges.Add(challenges[randomChallenges]);
                    }
                }
                
                foreach (Challenge challenge in selectChallenges)
                {
                    challenge.RunChallenge(theAdventurer);
                }

                if (theAdventurer.Awesomeness >= maxAwesomeness)
                {
                    Console.WriteLine("YOU DID IT! You are truly awesome!");
                }
                else if (theAdventurer.Awesomeness <= minAwesomeness)
                {
                    Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
                }
                else
                {
                    Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
                }

                Prize adventurerPrize = new Prize("The prize is this finger.");

                Console.WriteLine(adventurerPrize.ShowPrize(theAdventurer));


                Console.Write("Would you like to play again? (Y/N): ");
                Play = Console.ReadLine();
            }
        }
    }
}