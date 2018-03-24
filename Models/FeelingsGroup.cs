using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeMaiFaci.Models
{
    class FeelingsGroup
    {
        public FeelingsGroup()
        {
            Items = new List<string>();
        }
        public string Name { get; set; }
        public List<string> Items { get; set; }
        public List<int> Color { get; set; }
    }
}
