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
        public void ShowUsers()
        {
            string displayAllUsers = "CALL `miniMemList`();";
            sqlConnection.ShowCompressedListSQL(displayAllUsers);
        }

        public void ShowCompleteUser()
        {
            string callProcedure = "CALL `memberlist`();";
            sqlConnection.ShowUserSQL(callProcedure);
        }
    }
}