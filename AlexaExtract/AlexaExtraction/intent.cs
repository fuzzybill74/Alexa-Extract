using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaExtraction
{
    public class scIntent
    {
        public string intent { get; set; }
        public List<sc_slot> slots { get; set; }
    }
}
