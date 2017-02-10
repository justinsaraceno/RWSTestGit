using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RWSTestGit.Models
{
    public class Pizza
    {
        public string Name { get; set; }

        public List<string> Toppings { get; set; }

        public CrustStyle CrustStyle { get; set; }
    }
}
