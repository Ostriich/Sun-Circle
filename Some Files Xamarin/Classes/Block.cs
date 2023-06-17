using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary2.Classes
{
    [Serializable]
    public class Block
    {
        public string name { get; set; }
        public string[] jury { get; set; }
        public string[] notes { get; set; }
        public ParticipantRow[] rows { get; set; }
    }
}
