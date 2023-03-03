using System;

namespace Quest
{
    public class Challenge
    {
        private string _text;
        private int _correctAnswer;
        private int _awesomenessChange;
        public Challenge(string text, int correctAnswer, int awesomenessChange)
        {
            _text = text;
            _correctAnswer = correctAnswer;
            _awesomenessChange = awesomenessChange;
        }
        public void RunChallenge(Adventurer adventurer)
        {
            Console.Write($"{_text}: ");
            string answer = Console.ReadLine();

            int numAnswer;
            bool isNumber = int.TryParse(answer, out numAnswer);

            Console.WriteLine();
            if (isNumber && numAnswer == _correctAnswer)
            {
                Console.WriteLine("Well Done!");

                adventurer.Awesomeness += _awesomenessChange;
                adventurer.AwesomenessMultiplier++;
            }
            else
            {
                Console.WriteLine("You have failed the challenge, there will be consequences.");
                adventurer.Awesomeness -= _awesomenessChange;
            }
            Console.WriteLine(adventurer.GetAdventurerStatus());
            Console.WriteLine();
        }

        public static implicit operator string(Challenge v)
        {
            throw new NotImplementedException();
        }
    }
}