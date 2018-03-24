using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeMaiFaci.Models
{
    public class LogEntry
    {
        public DateTime TheDate { get; set; }
        public string Doing { get; set; }
        public string[] Feelings { get; set; }
        public string MyOwnFeelings { get; set; }
    }
}
