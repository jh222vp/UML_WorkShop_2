using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class EditUser
    {
        SQLconnection sqlConnection = new SQLconnection();
        public void EditUserInfo(string userEdit, string fName, string lName, string pNumber)
        {       
            string editUserQuery = "UPDATE member SET firstname='" + fName + "'" + ", lastname='" + lName + "'" + ", socialsecuritynumber= '" + pNumber + "'" + " WHERE memberID='" + userEdit + "'";
            sqlConnection.AddBoatSQL(editUserQuery);
        }
    }
}