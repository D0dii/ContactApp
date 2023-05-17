using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.StatesOfMachine
{
    public class DisplayContactState : IState
    {
        public void doAction(List<Contact> contacts)
        {
            string name;
            Console.WriteLine("Enter contact name:");
            name = Console.ReadLine();
            Console.WriteLine(contacts.FirstOrDefault(c => c.Name == name));
        }
    }
}
