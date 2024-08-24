using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace messengerX_v._1._0._0
{
    public class db:DbContext
    {
        public db():base("name = constr1")
        {
            
        }
        public DbSet<User> users { get; set; }
        public DbSet<Relations> relations { get; set; }
        public DbSet<BlockedUsers> blockedUser { get; set; }
        public DbSet<Message> messages { get; set; }


    }
}
