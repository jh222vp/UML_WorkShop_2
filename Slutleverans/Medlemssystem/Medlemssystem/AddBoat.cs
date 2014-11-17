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
        ShowUser showUser = new ShowUser();
        SQLconnection sqlConnection = new SQLconnection();
        public void AddBoatToMember()
        {
            Program program = new Program();

            showUser.ShowUsers();
            
            program.AddBoatInteraction(1);
            int userChoice = int.Parse(Console.ReadLine());

            program.AddBoatInteraction(2);
            string boatLength = Console.ReadLine();

            program.AddBoatInteraction(3);
            string boatType = Console.ReadLine();

            string addUserQuery = "INSERT INTO boat (memberID, boattypeID, boatlength) VALUES ( " + "'" + userChoice + "'" + "," + "'" + boatType + "'" + "," + "'" + boatLength + "'" + ")";

            sqlConnection.AddBoatSQL(addUserQuery);
            Console.Clear();
            Console.ReadLine();
        }
    }
}