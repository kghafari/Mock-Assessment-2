using System;
using System.Collections.Generic;

namespace MockAssessment2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            Console.WriteLine("#1");
            string[] addSWArray = { "Boba Fett", "BBYoda", "Annie", "Yoda", "Jar Jar" };
            Console.WriteLine($"Expected: 3, Result {AddStarWarsCharacters(addSWArray)}");



            // #2
            Console.WriteLine("\n#2");
            Dictionary<string, int> swCombatants = new Dictionary<string, int>
            {
                {"Darth Vader" , 100 },
                {"Obi Wan" , 75  },
                {"The High Ground", 9001 },
                {"Jar Jar", 125 },
            };
            Console.WriteLine($"Highest Power: {DeathStarCombat(swCombatants)}");


            // #3
            Console.WriteLine("\n#3");
            string[] planets = { "Naboo", "Hoth", "Degobah", "Tatooine" };
            List<string> planetList = ConvertPlanets(planets);

            for (int i = 0; i < planetList.Count; i++)
            {
                Console.WriteLine(planetList[i]);
            }

            // #4
            Console.WriteLine("\n#4");
            List<int> droidList = new List<int>
            {
                {2},{2},{2},{2},{2},{5}
            };
            Console.WriteLine($"Expected: 2, Result: {AverageDroids(droidList)} ");

            // #5
            Console.WriteLine("\n#5");
            string numberCatch = "123";
            string stringCatch = "NEVER!";

            string catch1 = TryToCatchDarthVader(numberCatch);
            string catch2 = TryToCatchDarthVader(stringCatch);

            Console.WriteLine(catch1);
            Console.WriteLine(catch2);
        }

        // #1 - Searches for, and returns the index of "Yoda" (as an int) from a string array.
        public static int AddStarWarsCharacters(string[] swCharacters)
        {
            int yodaPos = Array.IndexOf(swCharacters, "Yoda");
            return yodaPos;
        }

        // #2 Takes a list of names(string) and power levels(int), and returns the name of the strongest as a string.
        public static string DeathStarCombat(Dictionary<string, int> combatants)
        {
            int max = 0;
            string strongest = "";

            foreach (KeyValuePair<string, int> fighter in combatants)
            {

                if (fighter.Value > max)
                {
                    max = fighter.Value;
                    strongest = fighter.Key;
                }
            }
            return strongest;
        }

        // #3 Takes an array of planet names, converts to a list, and reverses the order.
        public static List<string> ConvertPlanets(string[] planets)
        {
            List<string> planetList = new List<string>();

            foreach (string planet in planets)
            {
                planetList.Add(planet);
            }
            planetList.Reverse();
            return planetList;
        }

        // #4 Takes a list of integers, adds all even numbers, and divides by total even numbered elements in the list.
        //      Returns average of even numbered elements.
        public static int AverageDroids(List<int> droids)
        {
            int count = 0;
            int numOfDroids = 0;
            int average = 0;
            foreach (int droid in droids)
            {
                if (droid % 2 == 0)
                {
                    count = count + droid;
                    numOfDroids++;
                }
                //average               
            }
            average = count / numOfDroids;
            return average;
        }


        // #5 Tries to parse a string. If successful, 
        //      returns "Captured" string. Else, causes a FormatException and throws "got away message"
        public static string TryToCatchDarthVader(string maybeVader)
        {
            try
            {
                int catcher = int.Parse(maybeVader);
                return "Vader Was Captured!";
            }
            catch (FormatException)
            {
                return "Vader Got Away!";
            }
        }
    }
}
