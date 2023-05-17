using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }

        public Human(string name, string surname, string email, int contactNumber)
        {
            Name = name;
            Surname = surname;
            Email = email;
            ContactNumber = contactNumber;
        }

        public override string ToString()
        {
            return $"Name:{Name} Surname:{Surname} Email:{Email} Contact Number:{ContactNumber}";
        }
    }
}
