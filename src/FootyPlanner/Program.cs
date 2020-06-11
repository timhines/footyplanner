using System;
using System.Collections.Generic;

namespace TimHines.FootyPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading players from CSV file...");

            CsvReader csv = new CsvReader("src/FootyPlanner/SeedPlayers.csv");
            List<Player> players = new List<Player>();
            Roster roster = new Roster();
            
            players = csv.ReadAllPlayers();
            Console.WriteLine($"Adding {players.Count} players from file into roster.");

            foreach(Player player in players)
            {
                roster.AddPlayer(player);
            }

            Console.WriteLine("Finished updating roster.");
            roster.PrintRoster();
        }
    }
}
