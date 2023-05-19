using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.StatesOfMachine
{
    public class GetInputFromUser
    {
        public string getInput()
        {
            Console.WriteLine("Enter contact name:");
            return Console.ReadLine();
            
        }
    }
}
