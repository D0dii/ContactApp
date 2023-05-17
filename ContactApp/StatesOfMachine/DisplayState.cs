using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.StatesOfMachine
{
    public class DisplayState : IState
    {
        public void doAction(List<Contact> contacts)
        {
            foreach(var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
