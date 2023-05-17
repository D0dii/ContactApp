using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    public class Contact
    {
        public string Name { get; set; }
        public Human Human { get; set; }
        public IList<Calling> Callings{ get; set; }

        public Contact(string name, Human human)
        {
            Name = name;
            Human = human;
        }

        public void call()
        {
            Console.WriteLine("Calling to "+Human.ToString());
            Callings.Add(new Calling(Human));
        }

        public override string ToString()
        {
            return $"Name of contact:{Name} {Human} {Callings}";
        }
    }
}
