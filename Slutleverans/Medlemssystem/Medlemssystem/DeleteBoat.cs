using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medlemssystem
{
    class DeleteBoat
    {
        ShowUser showUser = new ShowUser();
        Presentation presentation = new Presentation();
        
        SQLconnection sqlConnection = new SQLconnection();
        public void DeleteBoats()
        {
            Program program = new Program();
            showUser.ShowUsers();

            program.DeleteBoatInteraction(1);
            int userChoice = int.Parse(Console.ReadLine());

            string showBoatQuery = "CALL `displayBoat`" + "(" + userChoice + ");";

            sqlConnection.DeleteBoatSQL(showBoatQuery);

            program.DeleteBoatInteraction(2);
            int userBoatChoice = int.Parse(Console.ReadLine());

            string deleteBoatQuery = "CALL `deleteBoat`" + "(" + userBoatChoice + ");";
            sqlConnection.DeleteBoatSQL(deleteBoatQuery);

            Console.Clear();
            program.ContinueOnKeyPressed();
        }
    }
}
