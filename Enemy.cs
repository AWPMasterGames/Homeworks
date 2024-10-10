using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Enemy
{
    private enum Act { Search, Move, Attack }

    private Act _currentAction;
    private string _name;
    public string Name { get { return _name; } }

    public Enemy(string name)
    {
        _name = name;
        _currentAction = Act.Search;
    }

    private bool TrySearchTargget()
    {
        Console.WriteLine($"{Name} Пытаеться найти цель.");
        Random rnd = new Random();
        return new Random().Next(1, 3) == 1;
    }
    private bool TryMoveToTargget()
    {
        Console.WriteLine($"{Name} пытаеться добратся до неё.");
        Random rnd = new Random();
        return new Random().Next(1, 3) == 2;
    }
    private bool TryAtackTargget()
    {
        Console.WriteLine($"{Name} пытаеться атаковать её.");
        Random rnd = new Random();
        return new Random().Next(1, 3) == 2;
    }

    public void TryAction()
    {
        if (_currentAction == Act.Search)
        {
            if (TrySearchTargget())
            {
                Console.WriteLine($"{Name} обнаружил цель.");
                _currentAction = Act.Move;
            }
            else
            {
                Console.WriteLine($"{Name} не удалось обнаружить цель.");
            }
        }
        else if (_currentAction == Act.Move)
        {
            if (TryMoveToTargget())
            {
                Console.WriteLine($"{Name} добрался до цели.");
                _currentAction = Act.Attack;
            }
            else
            {
                Console.WriteLine($"{Name} не удалось добратся до цели.");
                _currentAction = Act.Search;
            }
        }
        else if (_currentAction == Act.Attack)
        {
            if (TryAtackTargget())
            {
                Console.WriteLine($"{Name} Атакует цель.");
                GameManager.HeroAtacks.Add(this);
                _currentAction = Act.Search;
            }
            else
            {
                Console.WriteLine($"{Name} не удалось атаовать цель.");
                _currentAction = Act.Search;
            }
        }
    }
}

