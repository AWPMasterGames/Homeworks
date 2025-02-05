using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class User
{
    private string _Login;
    private string _Password;
    private string _Name;
    private Permmisions _Permmisions;

    public string Login { get { return _Login; } set { _Login = value; } }
    public string Password { get { return _Password; } set { _Password = value; } }
    public string Name { get { return _Name; } set { _Name = value; } }
    public Permmisions Permmisions { get { return _Permmisions; } set { _Permmisions = value; } }

    public User() { }
    public User(string name, string login, string password, Permmisions perm)
    {
        _Name = name;
        _Login = login;
        _Password = password;
        _Permmisions = perm;
    }
    public override string ToString()
    {
        return $"Name: {Name}\t Login: {Login}\t Password: {Password}\t Permissions: {Permmisions.ToString()}";
    }
}