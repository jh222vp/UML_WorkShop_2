using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Medlemssystem
{
    class ShowUser
    {
        SQLconnection sqlConnection = new SQLconnection();
        public List<Member> ShowUsers()
        {
            string displayAllUsers = "CALL `miniMemList`();";
            List<Member> member = sqlConnection.ShowCompressedListSQL(displayAllUsers);
            return member;
        }

        public List<Member> ShowCompleteUser()
        {
            string callProcedure = "CALL `memberlist`();";
            List<Member> member = sqlConnection.ShowUserSQL(callProcedure);
            return member;
        }

        public List<Boat> ShowCompleteUserBoats()
        {
            string callProcedure = "CALL `memberlist`();";
            List<Boat> boat = sqlConnection.ShowUserBoatsSQL(callProcedure);
            return boat;
        }
    }
}