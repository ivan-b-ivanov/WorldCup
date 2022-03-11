using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldCup.TeamManager;

namespace WorldCup.TeamManagerTests
{
  [TestClass]
  public class TeamTests
  {
    [TestMethod]
    public void New_Team_Contains_No_Players()
    {
      Team team = new Team();
      Assert.AreEqual(0, team.Players);
    }
    [TestMethod]
    public void New_Team_Shows_No_Wins()
    {
      Team team = new Team();
      Assert.AreEqual(0, team.Wins);
    }
    [TestMethod]
    public void New_Team_Shows_No_Losses()
    {
      Team team = new Team();
      Assert.AreEqual(0, team.Losses);
    }
    [TestMethod]
    public void Team_Win_Is_Tracked()
    {
      Team team = new Team();
      team.Win();
      Assert.AreEqual(1, team.Wins);
    }
    [TestMethod]
    public void Team_Loss_Is_Tracked()
    {
      Team team = new Team();
      team.Lose();
      Assert.AreEqual(1, team.Losses);
    }

    [TestMethod]
    public void Team_Roster_Add_Is_Tracked()
    {
      Team team = new Team();
      team.RosterAdd();
      Assert.AreEqual(1, team.Players);
    }
    [TestMethod]
    public void Team_Roster_Remove_Is_Tracked()
    {
      Team team = new Team();
      team.RosterAdd();
      team.RosterRemove();
      Assert.AreEqual(0, team.Players);
    }
    [TestMethod]
    [ExpectedException(typeof(ApplicationException))]
    public void Team_Roster_Empty_Cannot_Remove()
    {
      Team team = new Team();
      team.RosterRemove();
      Assert.Fail();
    }

  }
}
