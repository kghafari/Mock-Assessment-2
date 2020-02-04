using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment2a_OneMoreTime
{
    class Challenge
    {

        //#1
        public static int AddStarWarsCharacters(string[] characters)
        {
            for (int i = 0; i < characters.Length; i++)
            {
                if(characters[i] == "Yoda")
                {
                    return i;
                }
            }
            return -1;
        }

        //#2
        public static string DeathStarCombat(Dictionary<string, int> fighters)
        {
            string jedi = "";
            int power = 0;

            foreach (var fighter in fighters)
            {
                if (fighter.Value > power)
                {
                    power = fighter.Value;
                    jedi = fighter.Key;
                }
            }
            return jedi;
        }

        //#3
        public static List<string> ConvertPlanets(string[] planets)
        {
            var planetList = new List<string>();
            foreach (string planet in planets)
            {
                planetList.Add(planet);
            }
            planetList.Reverse();
            return planetList;
        }

        //#4
        public static int AverageDroids(List<int> droids)
        {
            int total = 0;
            int numEvenDroids = 0;
            foreach (var droid in droids)
            {
                if(droid % 2 == 0)
                {
                    total += droid;
                    numEvenDroids++;
                }
            }
            int average = total / numEvenDroids;
            return average;
        }

        //#5
        public static string TryToCatchDarthVader(string maybeVader)
        {
            try
            {
                int.Parse(maybeVader);
                return "Vader Was Captured!";
            }
            catch(FormatException)
            {

                return "Vader Got Away";
            }
        }
    }
}
