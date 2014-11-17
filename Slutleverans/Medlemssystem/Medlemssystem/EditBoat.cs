using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class EditBoat
    {
        
        ShowUser showUser = new ShowUser();
        SQLconnection sqlConnection = new SQLconnection();
        public void EditBoats()
        {
            Program program = new Program();
            showUser.ShowUsers();

            program.EditBoatInteraction(1);
            int userChoice = int.Parse(Console.ReadLine());

            string showBoatQuery = "CALL `displayBoat`" + "(" + userChoice + ");";
            sqlConnection.DeleteBoatSQL(showBoatQuery);

            program.EditBoatInteraction(2);
            int userBoatChoice = int.Parse(Console.ReadLine());

            program.EditBoatInteraction(3);            
            string newBoatLength = Console.ReadLine();

            program.EditBoatInteraction(4);
            string newBoatype = Console.ReadLine();

            string editBoatQuery = "UPDATE boat SET boattypeID='" + newBoatype + "'" + ", boatlength='" + newBoatLength + "'" + " WHERE boatID='" + userBoatChoice + "'";

            sqlConnection.AddUserAndEditBoatSQL(editBoatQuery);

            Console.Clear();
            program.ContinueOnKeyPressed();
        }
    }
}
