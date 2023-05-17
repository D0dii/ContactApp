using ContactApp.StatesOfMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    public class StateMachine
    {
        public IState CurrentState;
        public void doAction(List<Contact> contacts)
        {
            CurrentState.doAction(contacts);
        }
    }
}
