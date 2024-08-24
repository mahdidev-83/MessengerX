using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messengerX_v._1._0._0
{
    public class BlockedUsers
    {
        public int id { get; set; }
        public int MainUserID { get; set; }
        public int relatedID { get; set;
        }

       /// <summary>
       /// to unblock a block person
       /// </summary>
       /// the id of the blocked person
       /// <param name="id"></param>
        public void unblck(int id)
        {
            db DB_UNBLCOK = new db();
            var q = from i in DB_UNBLCOK.blockedUser where i.relatedID == id select i;

            if(q.Count() == 1)
            {
                DB_UNBLCOK.blockedUser.Remove(q.Single());
                DB_UNBLCOK.SaveChangesAsync();
            }
        }

        

    }
}
