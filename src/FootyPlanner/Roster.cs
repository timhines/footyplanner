using System;
using System.Collections.Generic;

namespace TimHines.FootyPlanner
{
  // Describes a list of available players who could be used in a game
  public class Roster : IEnumerable<Player>
  {
    private List<Player> _players = new List<Player>();

    #region IEnumurable members
    public IEnumerator<Player> GetEnumerator()
    {
      foreach (Player player in _players)
      {
        yield return player;
      }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }
    #endregion

    // add a single player to the roster
    public void AddPlayer(Player player)
    {
      _players.Add(player);
    }

    // removes a single player from the roster
    public void RemovePlayer(int index)
    {
      _players.RemoveAt(index);
    }

    // gets a single player from the roster
    public Player GetPlayer(int index)
    {
      return _players[index];
    }

    // return all players on the roster in a list
    public List<Player> AllPlayers()
    {
      return _players;
    }

    // return available players on the roster in a list.  available means not inactive and not injured
    public List<Player> AvailablePlayers()
    {
      List<Player> available = _players.FindAll(x => !x.Inactive && !x.Injured);
      return available;
    }

    public void PrintRoster()
    {
      foreach (Player player in _players)
      {
        Console.WriteLine($"{player.First_name} {player.Last_name}, {player.Mobile_number}, Inactive: {player.Inactive}, Injured: {player.Injured}");
      }
    }

  }
}