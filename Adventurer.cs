using System;
using System.Collections.Generic;
using System.Linq;

namespace Quest
{
    public class Adventurer
    {
        public string Name { get; }
        public int Awesomeness { get; set; }
        public int AwesomenessMultiplier { get; set; }
        public Adventurer(string name, Robe colorfulRobe, Hat hat)
        {
            Name = name;
            Awesomeness = 50;
            ColorfulRobe = colorfulRobe;
            HatShininess = hat;
            AwesomenessMultiplier = 0;
        }
        public string GetAdventurerStatus()
        {
            string status = "okay";
            if (Awesomeness >= 75)
            {
                status = "great";
            }
            else if (Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomeness < 10 && Awesomeness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name}, is {status}";
        }
        public Robe ColorfulRobe { get; }
    
        public string GetDescription()
        {
            List<string> colors = ColorfulRobe.RobeColors;
            string colorsList = colors[0];
            for (int i = 1; i < colors.Count - 1; i++)
            {
                colorsList += $", {colors[i]}";
            }
            colorsList += $", and {colors.Last()}";
            string description = $"{Name} has a {colorsList} robe that is {ColorfulRobe.RobeLength} inches long, and is wearing a hat that is {HatShininess.ShininessDescription()}.";
            return description;
        }
        public Hat HatShininess { get; set; }
    }
}