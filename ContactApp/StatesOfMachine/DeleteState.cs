﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.StatesOfMachine
{
    public class DeleteState : IState
    {
        public void doAction(List<Contact> contacts)
        {
            string name;
            Console.WriteLine("Enter contact name:");
            name = Console.ReadLine();
            contacts.RemoveAll(c => c.Name == name);
        }
    }
}
