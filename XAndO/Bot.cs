using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Bot : User
{
    private int _Difficulty;
    private string _PlayerSymbol;
    private int count;
    private int[] RC = new int[2];

    public Bot(int diff, string symol, string ps)
    {
        _Symbol = symol;
        _Difficulty = diff;
        _PlayerSymbol = ps;
    }

    public override int[] Turn()
    {
        int[] RC = new int[2];
        switch (_Difficulty)
        {
            case 1:
                RC = EasyMode();
                break;
            case 2:
                RC = MediumMode();
                break;
            case 3:
                RC = HardMode();
                break;
        }

        return RC;
    }
    private void GetCell()
    {
        RC[0] = new Random().Next(0, 3);
        Thread.Sleep(new Random().Next(3, 50));
        RC[1] = new Random().Next(0, 3);
    }
    private bool CheckCell(int row, int col)
    {
        if (Game._Fieled[row][col] == "") return true;
        return false;
    }
    private int[] EasyMode()
    {
        GetCell();
        while (!CheckCell(RC[0], RC[1])) GetCell();
        return RC;
    }
    private int[] MediumMode()
    {
        if (count == 0)
        {
            EasyMode();
            count++;
        }
        else
        {
            HardMode();
            count = 0;
        }

        return RC;
    }
    private int[] HardMode()
    {
        {
            for (int i = 0; i < Game._Fieled.Length; i++)
            {
                if (Game._Fieled[i][0] == _PlayerSymbol & Game._Fieled[i][2] == _PlayerSymbol & Game._Fieled[i][1] == "")
                {
                    RC[0] = i;
                    RC[1] = 1;
                    return RC;
                }
            }
            for (int i = 0; i < Game._Fieled.Length; i++)
            {
                if (Game._Fieled[0][i] == _PlayerSymbol & Game._Fieled[2][i] == _PlayerSymbol & Game._Fieled[1][i] == "")
                {
                    RC[0] = 1;
                    RC[1] = i;
                    return RC;
                }
            }
        }
        {
            for (int i = 0; i < Game._Fieled.Length; i++)
            {
                if (Game._Fieled[i][0] == _PlayerSymbol & Game._Fieled[i][1] == _PlayerSymbol & Game._Fieled[i][2] == "")
                {
                    RC[0] = i;
                    RC[1] = 2;
                    return RC;
                }
            }
            for (int i = 0; i < Game._Fieled.Length; i++)
            {
                if (Game._Fieled[0][i] == _PlayerSymbol & Game._Fieled[1][i] == _PlayerSymbol & Game._Fieled[2][i] == "")
                {
                    RC[0] = 2;
                    RC[1] = i;
                    return RC;
                }
            }

            for (int i = 0; i < Game._Fieled.Length; i++)
            {

                if (Game._Fieled[2][i] == _PlayerSymbol & Game._Fieled[1][i] == _PlayerSymbol & Game._Fieled[0][i] == "")
                {
                    RC[0] = 0;
                    RC[1] = i;
                    return RC;
                }
            }
            for (int i = 0; i < Game._Fieled.Length; i++)
            {
                if (Game._Fieled[i][2] == _PlayerSymbol & Game._Fieled[i][1] == _PlayerSymbol & Game._Fieled[i][0] == "")
                {
                    RC[0] = i;
                    RC[1] = 0;
                    return RC;
                }
            }
        }
        {
            for (int i = 0; i < Game._Fieled.Length; i++)
            {

                if (Game._Fieled[2][i] == _Symbol & Game._Fieled[1][i] == _Symbol & Game._Fieled[0][i] == "")
                {
                    RC[0] = 0;
                    RC[1] = i;
                    return RC;
                }
            }
            for (int i = 0; i < Game._Fieled.Length; i++)
            {
                if (Game._Fieled[i][2] == _Symbol & Game._Fieled[i][1] == _Symbol & Game._Fieled[i][0] == "")
                {
                    RC[0] = i;
                    RC[1] = 0;
                    return RC;
                }
            }
        }
        if (Game._Fieled[0][2] == _PlayerSymbol & Game._Fieled[1][1] == _PlayerSymbol)
        {
            RC[0] = 2;
            RC[1] = 0;
            return RC;
        }
        if (Game._Fieled[1][1] == _PlayerSymbol & Game._Fieled[2][0] == _PlayerSymbol)
        {
            RC[0] = 2;
            RC[1] = 0;
            return RC;
        }
        if (Game._Fieled[1][1] == _PlayerSymbol & Game._Fieled[2][0] == _PlayerSymbol)
        {
            RC[0] = 2;
            RC[1] = 0;
            return RC;
        }
        if (CheckCell(0, 0))
        {
            RC[0] = 0;
            RC[1] = 0;
            return RC;
        }
        if (CheckCell(2, 2))
        {
            RC[0] = 2;
            RC[1] = 2;
            return RC;
        }
        if (CheckCell(1, 1))
        {
            RC[0] = 1;
            RC[1] = 1;
            return RC;
        }
        if (CheckCell(0, 2))
        {
            RC[0] = 0;
            RC[1] = 2;
            return RC;
        }
        if (CheckCell(2, 0))
        {
            RC[0] = 2;
            RC[1] = 0;
            return RC;
        }
        if (Game._Fieled[2][0] == _PlayerSymbol)
        {
            if (CheckCell(0, 1))
            {
                RC[0] = 0;
                RC[1] = 1;
                return RC;
            }
            if (CheckCell(1, 2))
            {
                RC[0] = 0;
                RC[1] = 0;
                return RC;
            }
        }
        if (CheckCell(2, 1))
        {
            RC[0] = 2;
            RC[1] = 1;
            return RC;
        }
        if (CheckCell(1, 0))
        {
            RC[0] = 1;
            RC[1] = 0;
            return RC;
        }
        if (CheckCell(1, 2))
        {
            RC[0] = 1;
            RC[1] = 2;
            return RC;
        }
        if (CheckCell(0, 1))
        {
            RC[0] = 0;
            RC[1] = 1;
            return RC;
        }



        return RC;
    }
}
