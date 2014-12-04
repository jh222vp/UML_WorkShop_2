using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class EditBoat
    {
        SQLconnection sqlConnection = new SQLconnection();
        public void EditBoats(int userChoice, int userBoatChoice, string newBoatLength, string newBoatype)
        {
            string showBoatQuery = "CALL `displayBoat`" + "(" + userChoice + ");";
            sqlConnection.DeleteBoatSQL(showBoatQuery);

            string editBoatQuery = "UPDATE boat SET boattypeID='" + newBoatype + "'" + ", boatlength='" + newBoatLength + "'" + " WHERE boatID='" + userBoatChoice + "'";
            sqlConnection.AddUserAndEditBoatSQL(editBoatQuery);
        }
    }
}
