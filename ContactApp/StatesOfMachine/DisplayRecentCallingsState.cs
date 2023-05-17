using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.StatesOfMachine
{
    public class DisplayRecentCallingsState : IState
    {
        public void doAction(List<Contact> contacts)
        {
            string name;
            Console.WriteLine("Enter contact name:");
            name = Console.ReadLine();
            Contact c = contacts.FirstOrDefault(c => c.Name == name);
            c.recentCallings();
        }
    }
}
