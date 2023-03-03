using System;

namespace Quest
{
    public class Prize
    {
        private string _text;
        public Prize(string text)
        {
            _text = text;
        }
        public string ShowPrize(Adventurer adventurer)
        {   
            string text = "";
            if (adventurer.Awesomeness > 0)
            {   
                for (int i = 0; i < adventurer.Awesomeness; i++)
                {
                    text += $" {_text}";
                }
            }
            else
            {
                text = "Here's some poop...loser.";
            }
            return text;
        }
    }
}