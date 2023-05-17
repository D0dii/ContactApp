using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.StatesOfMachine
{
    public class AddState : IState
    {
        void IState.doAction(List<Contact> contacts)
        {
            Console.WriteLine("Name of contact: ");
            string nameC = Console.ReadLine();
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Contact number: ");
            int contactNumber;
            Boolean succes = int.TryParse(Console.ReadLine(),out contactNumber);
            while(!succes)
            {
                Console.WriteLine("Invalid input");
                succes = int.TryParse(Console.ReadLine(), out contactNumber);
            }
            contacts.Add(new Contact(nameC,new Human(name,surname,email, contactNumber)));
        }
    }
}
