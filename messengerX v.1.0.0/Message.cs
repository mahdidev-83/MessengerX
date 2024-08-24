using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerX_v._1._0._0
{
    public class Message
    {
        public int id { get; set; }
        public string text { get; set; } 
        public int fromU { get; set; }
        public int toU { get; set; }
        public DateTime datetime { get; set; }
        public string Owner { get; set; }

    }
}
