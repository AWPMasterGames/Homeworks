using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Game
{
    public int TurnCount = 0;
    public string SymbolWin = "";
    public string TurnSymbol = "X";
    public static string[][] _Fieled = new string[3][];

    public Game()
    {
        for (int i = 0; i < _Fieled.Length; i++) _Fieled[i] = new string[3];
    }

    public bool Turn(int row, int col, string symbol)
    {
        bool Win = false;
        _Fieled[row][col] = symbol;
        Win = CheckWin();
        return Win;
    }
    public void Restart()
    {
        TurnCount = 0;
        SymbolWin = "";
        TurnSymbol = "X";
        for (int i = 0; i < _Fieled.Length; i++)
        {
            for(int j = 0; j < _Fieled[i].Length; j++)
            {
                _Fieled[i][j] = "";
            }
        }
    }
    private bool CheckWin()
    {

        for (int i = 0; i < _Fieled.Length; i++)
        {
            int X = 0;
            int O = 0;
            for (int j = 0; j < _Fieled[i].Length; j++)
            {
                if (_Fieled[i][j] == "X") X++;
                if (_Fieled[i][j] == "O") O++;
            }
            if(X == 3)
            {
                SymbolWin = "X";
                return true;
            }
            if (O == 3)
            {
                SymbolWin = "O";
                return true;
            }
            X = 0;
            O = 0;

            for (int j = 0; j < _Fieled[i].Length; j++)
            {
                if (_Fieled[j][i] == "X") X++;
                if (_Fieled[j][i] == "O") O++;
            }
            if (X == 3)
            {
                SymbolWin = "X";
                return true;
            }
            if (O == 3)
            {
                SymbolWin = "O";
                return true;
            }
        }

        if (_Fieled[0][0] == "X" & _Fieled[1][1] == "X" & _Fieled[2][2] == "X")
        {
            SymbolWin = "X";
            return true;
        }
        if (_Fieled[0][2] == "X" & _Fieled[1][1] == "X" & _Fieled[2][0] == "X")
        {
            SymbolWin = "X";
            return true;
        }
        if (_Fieled[0][0] == "O" & _Fieled[1][1] == "O" & _Fieled[2][2] == "O")
        {
            SymbolWin = "O";
            return true;
        }
        if (_Fieled[0][2] == "O" & _Fieled[1][1] == "O" & _Fieled[2][0] == "O")
        {
            SymbolWin = "O";
            return true;
        }
        TurnCount++;
        return false;
    }
}

