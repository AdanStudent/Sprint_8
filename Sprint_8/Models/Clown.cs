using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint_8.Models
{
    public class Clown : IActor
    {
        public int Age { get; set; }

        public string Name { get; }

        public Clown()
        {
            this.Age = 32;
            this.Name = "Jeff";
        }

        public string About()
        {
            return $"Hi! My name is {this.Name} the Clown";
        }

        public string Performance()
        {
            return "HONK! BOnK HONK!";
        }
    }
}
