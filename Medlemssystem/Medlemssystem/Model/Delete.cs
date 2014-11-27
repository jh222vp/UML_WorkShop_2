using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class Delete
    {
        SQLconnection sqlConnection = new SQLconnection();

        public void DeleteUsers(int deleteChoice)
        {
           string deleteMemberQuery = "CALL `deleteMember`" + "(" + deleteChoice + ");";
           sqlConnection.DeleteBoatSQL(deleteMemberQuery);
        }
    }
}