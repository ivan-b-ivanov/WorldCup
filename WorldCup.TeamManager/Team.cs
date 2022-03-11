using System;

namespace WorldCup.TeamManager
{
    public class Team
    {
    private string _name;
    private int _players, _wins, _losses;
    public Team()
    {
      _players = 0;
      _wins = 0;
      _losses = 0;
    }

    public Team(string Name) : this()
    {
      _name = Name;
    }

    public string Name
    {
      get { return _name; }
    }
    public double Players
    {
      get { return _players; }
    }
    public double Wins
    {
      get { return _wins; }
    }
    public double Losses
    {
      get { return _losses; }
    }
    public void Win()
    {
      _wins++;
    }
    public void Lose()
    {
      _losses++;
    }
    public void RosterAdd()
    {
      _players++;
    }
    public void RosterRemove()
    {
      if (_players < 1)
      {
        throw new ApplicationException("No players to remove");
      }
      _players--;
    }
  }
}
