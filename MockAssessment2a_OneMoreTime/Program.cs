using System;
using System.Collections.Generic;

namespace MockAssessment2a_OneMoreTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            Console.WriteLine("#1");
            string[] addSWArray = { "Boba Fett", "BBYoda", "Annie", "Yoda", "Jar Jar" };
            Console.WriteLine($"Expected: 3, Result {Challenge.AddStarWarsCharacters(addSWArray)}");



            // #2
            Console.WriteLine("\n#2");
            Dictionary<string, int> swCombatants = new Dictionary<string, int>
            {
                {"Darth Vader" , 100 },
                {"Obi Wan" , 75  },
                {"The High Ground", 9001 },
                {"Jar Jar", 125 },
            };
            Console.WriteLine($"Highest Power: {Challenge.DeathStarCombat(swCombatants)}");


            // #3
            Console.WriteLine("\n#3");
            string[] planets = { "Naboo", "Hoth", "Degobah", "Tatooine" };
            List<string> planetList = Challenge.ConvertPlanets(planets);

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
            Console.WriteLine($"Expected: 2, Result: {Challenge.AverageDroids(droidList)} ");

            // #5
            Console.WriteLine("\n#5");
            string numberCatch = "123";
            string stringCatch = "NEVER!";

            string catch1 = Challenge.TryToCatchDarthVader(numberCatch);
            string catch2 = Challenge.TryToCatchDarthVader(stringCatch);

            Console.WriteLine(catch1);
            Console.WriteLine(catch2);
        }
    }
}
