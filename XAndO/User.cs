using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class User
{
    protected string _Symbol;
    public string Symbol { get { return _Symbol; } }

    public virtual int[] Turn()
    {
        int[] RC = new int[2];

        RC[0] = new Random().Next(0, 3);
        Thread.Sleep(new Random().Next(3, 100));
        RC[1] = new Random().Next(0, 3);

        return RC;
    }
}

