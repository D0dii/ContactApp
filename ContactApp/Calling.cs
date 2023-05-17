using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    public class Calling
    {
        public DateTime DateOfCalling { get; set; }
        public Human Human { get; set; }

        public Calling(Human Human)
        {
            DateOfCalling = DateTime.Now;
            this.Human = Human;
        }

        public override string ToString()
        {
            return $"Called {DateOfCalling} to {Human}";
        }
    }
}
