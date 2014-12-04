using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Medlemssystem
{
    class AddBoat
    {
        SQLconnection sqlConnection = new SQLconnection();
        public void AddBoatToMember(int userChoice, string boatLength, string boatType)
        {
            string addUserQuery = "INSERT INTO boat (memberID, boattypeID, boatlength) VALUES ( " + "'" + userChoice + "'" + "," + "'" + boatType + "'" + "," + "'" + boatLength + "'" + ")";
            sqlConnection.AddBoatSQL(addUserQuery);
        }
    }
}