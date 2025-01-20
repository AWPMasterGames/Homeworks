using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bot : Player
{
    private Random random = new Random();

    private List<int> _TryNumbers = new List<int>();
    private User _User;
    private int _TryCount;

    public int TryCount { get { return _TryCount; } }

    public Bot(User user)
    {
        _Number = random.Next(1, 2001);
        _User = user;
    }
    private bool FindNumInPrevNumberTry()
    {
        for (int i = 0; i < _TryNumbers.Count; i++)
        {
            if (_Number == _TryNumbers[i]) return true;
        }
        return false;
    }
    private void GuessNumber()
    {
        
        for (int i = 0; _Number != _User.GetNumber(); i++)
        {
            if (!FindNumInPrevNumberTry())
            {
                _TryNumbers.Add(_Number);
                _TryCount++;
            }

            _Number = random.Next(1, 2001);
            if (_Number == _User.GetNumber())
            {
                return;
            }
            

        }
    }
    public override int GetNumber()
    {
        GuessNumber();
        return _Number;
    }
}

