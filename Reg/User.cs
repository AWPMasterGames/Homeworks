using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class User
{
    private string _Name;
    private string _Email;
    private string _Password;
    private string _BirthDay;

    public string Name { get { return _Name; } }
    public string Email { get { return _Email; } }
    public string Password { get { return _Password; } }
    public string Birthday { get { return _BirthDay; } }

    public User() { }
    public User(string name, string email, string password, string birthday)
    {
        this._Name = name;
        this._Email = email;
        this._Password = password;
        this._BirthDay = birthday;
    }
}