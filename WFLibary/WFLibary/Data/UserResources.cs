using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public static class UserResources
{
    private static List<User> ListOfUser;

    public static List<User> GetListOfUser()
    {
        if(ListOfUser == null)
        {
            ListOfUser = new List<User>();
            ListOfUser.Add(new User("Admin","admin","123",Permmisions.Admin));
            ListOfUser.Add(new User("Worker","worker","123",Permmisions.Worker));
            ListOfUser.Add(new User("Guest","visitor","123",Permmisions.Visitor));
        }
        return ListOfUser;
    }
    public static void AddUserToLisr(User user, ListBox listBox)
    {
        ListOfUser.Add(user);
        listBox.Items.Add(user);
    }
    public static void RemoveUserToLisr(User user, ListBox listBox)
    {
        ListOfUser.Remove(user);
        listBox.Items.Remove(user);
    }
    public static void EditUserToLisr(User user, ListBox listbox)
    {
        ListOfUser.Remove(user);
        listbox.Items.Remove(user);
        ListOfUser.Add(user);
        listbox.Items.Add(user);

    }
}

