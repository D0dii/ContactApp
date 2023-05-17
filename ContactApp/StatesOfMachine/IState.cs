using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.StatesOfMachine
{
    public interface IState
    {
        void doAction(List<Contact> contacts);
    }
}
