using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LeaderBoard
{
    public List<User> Users = new List<User>();

    public void AddUser(User user)
    {
        for(int i = 0; i < Users.Count; i++)
        {
            for (int j = 0; j < Users.Count; j++)
            {
                if (Users[j].Name == user.Name)
                {
                    Users[j].ChangeTime(user.Time);

                    ChangeLeaderBoard();
                    return;
                }
            }
        }
        Users.Add(user);

        ChangeLeaderBoard();
    }
    public bool IsUserExist(User user)
    {
        for (int i = 0; i < Users.Count; i++)
        {
            if (Users[i].Name == user.Name)
            {
                
                return true;
            }
        }
        return false;
    }
    public int GetUserIndex(User user)
    {
        int index = 0;
        for(int i = 0; i < Users.Count;i++ )
        {
            if(Users[i].Name == user.Name)
            {
                index = i; 
                break;
            }
        }
        return index;
    }
    public void ChangeLeaderBoard()
    {
        if (Users.Count <= 1) return;
        for (int i = 0; i < Users.Count-1; i++)
        {
            if (int.Parse(Users[i].Time) > int.Parse(Users[i+1].Time)) { 
                User temp = Users[i];
                Users[i] = Users[i+1];
                Users[i+1] = temp;
            }
        }
    }
}

