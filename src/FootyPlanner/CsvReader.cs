using System;
using System.Collections.Generic;
using System.IO;

namespace TimHines.FootyPlanner
{
  public class CsvReader
  {
    private string _filepath;
    public CsvReader(string filepath)
    {
      _filepath = filepath;
    }

    public List<Player> ReadAllPlayers()
    {
      List<Player> players = new List<Player>();

      using(StreamReader sr = new StreamReader(_filepath))
      {
        // read the header line and throw it away
        sr.ReadLine();

        // read the first data line 
        string csvline = sr.ReadLine();

        // loop through each row
        while (csvline != null)
        {
          Player player = GetPlayerFromCsvLine(csvline);
          players.Add(player);
          csvline = sr.ReadLine();
        }
      }
      return players;
    }

    private Player GetPlayerFromCsvLine(string csvline)
    {
      string[] columns = csvline.Split(",");
      Player player = new Player();
      player.First_name = columns[0];
      player.Last_name = columns[1];
      player.Mobile_number = columns[2];

      if (columns[3] == "true")
      {
        player.Inactive = true;
      }
      
      if (columns[4] == "true")
      {
        player.Injured = true;
      }

      return player;
    }
  }
}