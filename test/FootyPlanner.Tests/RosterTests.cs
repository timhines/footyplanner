using System;
using System.Collections.Generic;
using Xunit;

namespace TimHines.FootyPlanner.Tests
{
    public class RosterTests
    {
        [Fact]
        public void AddRemovePlayers()
        {
            Roster roster = new Roster();
            Player player1 = new Player("Tim", "Hines", "07786062333");
            Player player2 = new Player("Will", "Hearn", "07971323947");

            roster.AddPlayer(player1);
            roster.AddPlayer(player2);

            Assert.Equal(2, roster.AllPlayers().Count);

            roster.RemovePlayer(0);

            Assert.Equal(1, roster.AllPlayers().Count);
            Assert.Equal("Will", roster.GetPlayer(0).First_name);
        }

        [Fact]
        public void GetPlayerAndAvailability()
        {
            Roster roster = new Roster();
            Player player1 = new Player("Tim", "Hines", "07786062333");
            Player player2 = new Player("Will", "Hearn", "07971323947");
            
            player2.Inactive = true;
            player2.Injured = true;
            roster.AddPlayer(player1);
            roster.AddPlayer(player2);
        
            List<Player> available = new List<Player>();
            available = roster.AvailablePlayers();

            Assert.Equal("Tim", roster.GetPlayer(0).First_name);
            Assert.Equal("Hines", roster.GetPlayer(0).Last_name);
            Assert.Equal("07786062333", roster.GetPlayer(0).Mobile_number);
            Assert.Equal(false, roster.GetPlayer(0).Inactive);
            Assert.Equal(false, roster.GetPlayer(0).Injured);

            Assert.Equal("Will", roster.GetPlayer(1).First_name);
            Assert.Equal("Hearn", roster.GetPlayer(1).Last_name);
            Assert.Equal("07971323947", roster.GetPlayer(1).Mobile_number);
            Assert.Equal(true, roster.GetPlayer(1).Inactive);
            Assert.Equal(true, roster.GetPlayer(1).Injured);

            Assert.Equal(1, roster.AvailablePlayers().Count);
            Assert.Equal("Tim", available[0].First_name);
        }
    }
}
