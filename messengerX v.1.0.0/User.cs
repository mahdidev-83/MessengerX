using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerX_v._1._0._0
{
    public class User
    {
        // the major information about User
       public int id { get; set; }
       public string UserName { get; set; }
       public string Email { get; set; }
       public string Password { get; set; }
       public string RegisterTime { get; set; } 
       public int USERCODE { get; set; }
       public string UserIdentity { get; set; }
       public bool isOnline { get; set; } 
       public byte[] ProfilePicture { get; set; }

        public bool isBlocked { get; set; }


        

    
       
       




    }
}
