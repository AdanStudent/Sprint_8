using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint_8.Models
{
    public class Mime : IActor
    {
        public int Age { get; set; }

        public string Name { get; }

        public Mime()
        {
            this.Age = 36;
            this.Name = "Jeff";
        }

        public string About()
        {
            return $"Hi! My name is {this.Name} the Mime";
        }

        public string Performance()
        {
            return "*Strained Faced and difficutly walking because of high winds*";
        }
    }
}
