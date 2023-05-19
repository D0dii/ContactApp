using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.StatesOfMachine
{
    public class DeleteState : IState
    {
        private GetInputFromUser GetInputFromUser;
        public DeleteState()
        {
            GetInputFromUser = new GetInputFromUser();
        }
        public void doAction(List<Contact> contacts)
        {
            string name = GetInputFromUser.getInput();
            contacts.RemoveAll(c => c.Name == name);
        }
    }
}
