using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Test
{
    private LeaderBoard _LeaderBoard = new LeaderBoard();
    private string _name;
    public string Name {  get { return _name; } }
    public Test(string name ,LeaderBoard leaderBoard)
    {
        _name = name;
        //_LeaderBoard = leaderBoard;
        for (int i = 0; i < leaderBoard.Users.Count; i++)
        {
            _LeaderBoard.AddUser(leaderBoard.Users[i]);
        }
    }
    public LeaderBoard GetLeaderBoard()
    {
        return _LeaderBoard;
    }
}

