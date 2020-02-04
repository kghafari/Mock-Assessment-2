using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockAssessment_WithAnna
{
    class Challenge
    {


        public static int AddStarWarsCharacters(string[] swArray)
        {
            for (int i = 0; i < swArray.Length; i++)
            {
                if(swArray[i] == "Yoda")
                {
                    return i;
                }              
            }
            return -1;
        }
                                            //Dictionary <key, value>
        public static string DeathStarCombat(Dictionary<string, int> jedis)
        {
            string jedi = "";
            int power = -1;
            foreach (var character in jedis)
            {
                if(character.Value > power)
                {
                    power = character.Value;
                    jedi = character.Key;
                }
            }
            return jedi;
        }

        public static List<string> ConvertPlanets(string[] planets)
        {
            var planetList = new List<string>();

            foreach (var planet in planets)
            {
                planetList.Add(planet);
            }

            planetList.Reverse();
            return planetList;
        }

        public static double AverageDroids(List<int> droids)
        {
            var evenDroidList = new List<int>();
            foreach (int droid in droids)
            {
                if(droid % 2 == 0)
                {
                    evenDroidList.Add(droid);
                }
            }
            return evenDroidList.Average();
        }

        public static string TryToCatchDarthVader(string maybeVader)
        {
            try
            {
                int vaderNum = int.Parse(maybeVader);
                return "Vader Was Captured";
            }
            catch(FormatException)
            {
                return "Vader Got Away";
            }
        }


    }
}
