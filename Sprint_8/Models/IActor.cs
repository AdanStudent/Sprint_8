using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint_8.Models
{
    public interface IActor
    {
        int Age { get; set; }
        string Name { get; }

        string Performance();

        string About();
    }
}
