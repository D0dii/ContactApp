using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.StatesOfMachine
{
    public class DisplayContactState : IState
    {
        private GetInputFromUser GetInputFromUser;
        public DisplayContactState()
        {
            GetInputFromUser = new GetInputFromUser();
        }
        public void doAction(List<Contact> contacts)
        {
            string name = GetInputFromUser.getInput();
            Contact c = contacts.FirstOrDefault(c => c.Name == name);
            if (c != null)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
