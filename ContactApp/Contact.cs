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
            Callings = new List<Calling>();
        }

        public void call()
        {
            Console.WriteLine("Calling to "+Name);
            Callings.Add(new Calling(Human));
        }

        public override string ToString()
        {
            return $"Name of contact:{Name} {Human}";
        }

        public void recentCallings()
        {
            foreach(Calling call in Callings)
            {
                Console.WriteLine(call);
            }
        }
    }
}
