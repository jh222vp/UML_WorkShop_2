using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class DeleteBoat
    {
        
        
        SQLconnection sqlConnection = new SQLconnection();
        public void DeleteBoats(int userChoice, int userBoatChoice)
        {
            string showBoatQuery = "CALL `displayBoat`" + "(" + userChoice + ");";
            sqlConnection.DeleteBoatSQL(showBoatQuery);

            string deleteBoatQuery = "CALL `deleteBoat`" + "(" + userBoatChoice + ");";
            sqlConnection.DeleteBoatSQL(deleteBoatQuery);
        }
    }
}
